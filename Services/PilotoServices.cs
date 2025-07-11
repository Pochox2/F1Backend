using AutoMapper;
using Formula1Backend.Utils;
using Formula1Backend.Config;
using Formula1Backend.Models.Entities;
using Formula1Backend.Models.Piloto.Dto;
using Microsoft.EntityFrameworkCore;
using System.Net;


namespace Formula1Backend.Services
{
    public class PilotoServices
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;

        public PilotoServices(IMapper mapper, ApplicationDbContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        private async Task<Piloto> GetOneByIdOrException(int id)
        {
            var piloto = await _db.Pilotos.FirstOrDefaultAsync(e => e.Id == id);
            if (piloto == null)
            {
                throw new HttpError($"No se encontró el piloto con ID = {id}", HttpStatusCode.NotFound);
            }
            return piloto;
        }

        public async Task<List<AllPilotosDTO>> GetAll()
        {
            var pilotosDb = await _db.Pilotos.ToListAsync();
            var pilotos = _mapper.Map<List<AllPilotosDTO>>(pilotosDb);
            return pilotos;
        }

        public async Task<AllPilotosDTO> GetOneById(int id)
        {
            var piloto = await GetOneByIdOrException(id);
            return _mapper.Map<AllPilotosDTO>(piloto);
        }

        public async Task<AllPilotosDTO> CreateOne(CreatePilotoDTO createDto)
        {
            var piloto = _mapper.Map<Piloto>(createDto);
            await _db.Pilotos.AddAsync(piloto);
            await _db.SaveChangesAsync();

            return _mapper.Map<AllPilotosDTO>(piloto);
        }

        public async Task<AllPilotosDTO> UpdateOneById(int id, UpdatePilotoDTO updateDto)
        {
            var pilotoToUpdate = await GetOneByIdOrException(id);
            if (pilotoToUpdate.Seed)
                throw new HttpError("No se puede editar un piloto predefinido.", HttpStatusCode.Forbidden);

            _mapper.Map(updateDto, pilotoToUpdate);

            _db.Pilotos.Update(pilotoToUpdate);
            await _db.SaveChangesAsync();

            return _mapper.Map<AllPilotosDTO>(pilotoToUpdate);
        }

        public async Task DeleteOneById(int id)
        {
            var piloto = await GetOneByIdOrException(id);

            if (piloto.Seed)
                throw new HttpError("No se puede editar un piloto predefinido.", HttpStatusCode.Forbidden);

            _db.Pilotos.Remove(piloto);
            await _db.SaveChangesAsync();

            if (await _db.Pilotos.AnyAsync(e => e.Id == id))
            {
                throw new HttpError($"No se pudo eliminar el piloto con ID = {id}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
