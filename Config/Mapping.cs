using AutoMapper;
using Formula1Backend.Models.Entities;
using Formula1Backend.Models.Escuderia.Dto;
using Formula1Backend.Models.Piloto.Dto;
using Formula1Backend.Models.Pista.Dto;


namespace Formula1Backend.Config
{
    public class Mapping : Profile
    {
        public Mapping() {
        
            CreateMap<int?, int>().ConvertUsing((src, dest) => src ?? dest);
            CreateMap<List<string>?, List<string>>().ConvertUsing((src, dest) => src ?? dest);


            CreateMap<Escuderia, AllEscuderiasDTO>().ReverseMap();
            CreateMap<CreateEscuderiaDTO, Escuderia>().ReverseMap();
            CreateMap<UpdateEscuderiaDTO, Escuderia>()
                .ForAllMembers(opts =>
                {
                    opts.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Piloto, AllPilotosDTO>().ReverseMap();
            CreateMap<CreatePilotoDTO, Piloto>().ReverseMap();
            CreateMap<UpdatePilotoDTO, Piloto>()
                .ForAllMembers(opts =>
                {
                    opts.Condition((src, dest, srcMember) => srcMember != null);
                });

            CreateMap<Pista, AllPistasDTO>().ReverseMap();
            CreateMap<CreatePistaDTO, Pista>().ReverseMap();
            CreateMap<UpdatePistaDTO, Pista>()
                .ForAllMembers(opts => {
                opts.Condition((src, dest, srcMember) => srcMember != null);
                });

        }
    }
}
        