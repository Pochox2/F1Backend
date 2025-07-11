using AutoMapper;
using Formula1Backend.Utils;
using Formula1Backend.Config;
using Formula1Backend.Models.Entities;
using Formula1Backend.Models.Escuderia.Dto;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace Formula1Backend.Services
{
	public class EscuderiaServices
	{
		private readonly IMapper _mapper;
		private readonly ApplicationDbContext _db;

		public EscuderiaServices(IMapper mapper, ApplicationDbContext db)
		{
			_mapper = mapper;
			_db = db;
		}

		private async Task<Escuderia> GetOneByIdOrException(int id)
		{
			var escuderia = await _db.Escuderias.FirstOrDefaultAsync(e => e.Id == id);
			if (escuderia == null)
			{
				throw new HttpError($"No se encontró la escudería con ID = {id}", HttpStatusCode.NotFound);
			}
			return escuderia;
		}

		public async Task<List<AllEscuderiasDTO>> GetAll()
		{
			var escuderiasDb = await _db.Escuderias.ToListAsync();
			var escuderias = _mapper.Map<List<AllEscuderiasDTO>>(escuderiasDb);
			return escuderias;
		}

		public async Task<AllEscuderiasDTO> GetOneById(int id)
		{
			var escuderia = await GetOneByIdOrException(id);
			return _mapper.Map<AllEscuderiasDTO>(escuderia);
		}

		public async Task<AllEscuderiasDTO> CreateOne(CreateEscuderiaDTO createDto)
		{
			var escuderia = _mapper.Map<Escuderia>(createDto);
			await _db.Escuderias.AddAsync(escuderia);
			await _db.SaveChangesAsync();

			return _mapper.Map<AllEscuderiasDTO>(escuderia);
		}

		public async Task<AllEscuderiasDTO> UpdateOneById(int id, UpdateEscuderiaDTO updateDto)
		{
			var escuderiaToUpdate = await GetOneByIdOrException(id);

			if (escuderiaToUpdate.Seed)

				throw new HttpError("No se puede editar una escuderia predefinida.", HttpStatusCode.Forbidden);

			_mapper.Map(updateDto, escuderiaToUpdate);

			_db.Escuderias.Update(escuderiaToUpdate);
			await _db.SaveChangesAsync();

			return _mapper.Map<AllEscuderiasDTO>(escuderiaToUpdate);
		}

		public async Task DeleteOneById(int id)
		{
			var escuderia = await GetOneByIdOrException(id);

            if (escuderia.Seed)

                throw new HttpError("No se puede editar una escuderia predefinida.", HttpStatusCode.Forbidden);

            _db.Escuderias.Remove(escuderia);
			await _db.SaveChangesAsync();

			if (await _db.Escuderias.AnyAsync(e => e.Id == id))
			{
				throw new HttpError($"No se pudo eliminar la escudería con ID = {id}", HttpStatusCode.InternalServerError);
			}
		}
	}
}
