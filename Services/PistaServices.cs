using AutoMapper;
using Formula1Backend.Utils;
using Formula1Backend.Config;
using Formula1Backend.Models.Entities;
using Formula1Backend.Models.Pista.Dto;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace Formula1Backend.Services
{
    public class PistaServices
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;

        public PistaServices(IMapper mapper, ApplicationDbContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        private async Task<Pista> GetOneByIdOrException(int id)
        {
            var pista = await _db.Pistas.FirstOrDefaultAsync(e => e.Id == id);
            if (pista == null)
            {
                throw new HttpError($"No se encontró la pista con ID = {id}", HttpStatusCode.NotFound);
            }
            return pista;
        }

        public async Task<List<AllPistasDTO>> GetAll()
        {
            var pistasDb = await _db.Pistas.ToListAsync();
            var pistas = _mapper.Map<List<AllPistasDTO>>(pistasDb);
            return pistas;
        }

        public async Task<AllPistasDTO> GetOneById(int id)
        {
            var pista = await GetOneByIdOrException(id);
            return _mapper.Map<AllPistasDTO>(pista);
        }

        public async Task<AllPistasDTO> CreateOne(CreatePistaDTO createDto)
        {
            var pista = _mapper.Map<Pista>(createDto);
            await _db.Pistas.AddAsync(pista);
            await _db.SaveChangesAsync();

            return _mapper.Map<AllPistasDTO>(pista);
        }

        public async Task<AllPistasDTO> UpdateOneById(int id, UpdatePistaDTO updateDto)
        {
            var pistaToUpdate = await GetOneByIdOrException(id);
            
            if (pistaToUpdate.Seed)
                throw new HttpError("No se puede editar una pista predefinida.", HttpStatusCode.Forbidden);

            _mapper.Map(updateDto, pistaToUpdate);

            _db.Pistas.Update(pistaToUpdate);
            await _db.SaveChangesAsync();

            return _mapper.Map<AllPistasDTO>(pistaToUpdate);
        }

        public async Task DeleteOneById(int id)
        {
            var pista = await GetOneByIdOrException(id);

            if (pista.Seed)
                throw new HttpError("No se puede editar una pista predefinida.", HttpStatusCode.Forbidden);

            _db.Pistas.Remove(pista);
            await _db.SaveChangesAsync();

            if (await _db.Pistas.AnyAsync(e => e.Id == id))
            {
                throw new HttpError($"No se pudo eliminar la pista con ID = {id}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
