using Formula1Backend.Config;
using Formula1Backend.Models.Entities;

namespace Formula1Backend.Seeders
{
    public static class PistaSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Pistas.Any())
            {
                context.Pistas.AddRange(
                    new Pista { Id = 1, Nombre = "Circuito Internacional de Baréin", Ubicacion = "Sakhir, Baréin", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true },
                    new Pista { Id = 2, Nombre = "Circuito de la Corniche de Jeddah", Ubicacion = "Yeda, Arabia Saudita", Tipo = "Híbrido", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 3, Nombre = "Circuito de Albert Park", Ubicacion = "Melbourne, Australia", Tipo = "Híbrido", MejorPilotoId = 3, Seed = true },
                    new Pista { Id = 4, Nombre = "Circuito Internacional de Shanghái", Ubicacion = "Shanghái, China", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 5, Nombre = "Circuito de Suzuka", Ubicacion = "Suzuka - Mie, Japón", Tipo = "Autódromo", MejorPilotoId = 8, Seed = true },
                    new Pista { Id = 6, Nombre = "Autódromo Internacional de Miami", Ubicacion = "Miami, EE.UU", Tipo = "Híbrido", MejorPilotoId = 5, Seed = true },
                    new Pista { Id = 7, Nombre = "Autodromo Enzo e Dino Ferrari", Ubicacion = "Imola, Italia", Tipo = "Autódromo", MejorPilotoId = 18, Seed = true },
                    new Pista { Id = 8, Nombre = "Circuito de Monaco", Ubicacion = "Montecarlo, Mónaco", Tipo = "Callejero", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 9, Nombre = "Circuito de Barcelona-Cataluña", Ubicacion = "Montmeló - Barcelona, Cataluña", Tipo = "Autódromo", MejorPilotoId = 8, Seed = true },
                    new Pista { Id = 10, Nombre = "Circuito Gilles Villeneuve", Ubicacion = "Montreal, Canadá", Tipo = "Híbrido", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 11, Nombre = "Red Bull Ring", Ubicacion = "Spielberg, Austria", Tipo = "Autódromo", MejorPilotoId = 3, Seed = true },
                    new Pista { Id = 12, Nombre = "Circuito de Silverstone", Ubicacion = "Inglaterra, Reino Unido", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true },
                    new Pista { Id = 13, Nombre = "Circuit de spa-Francorchamps", Ubicacion = "Francorchamps, Lieja, Bélgica", Tipo = "Híbrido", MejorPilotoId = 5, Seed = true },
                    new Pista { Id = 14, Nombre = "Pista: Hungaroring", Ubicacion = "Mogyoród, Hungría", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 15, Nombre = "Circuito de Zandvoordt", Ubicacion = "Zandvoordt, Países Bajos", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true },
                    new Pista { Id = 16, Nombre = "Autodromo Nazionale di monza", Ubicacion = "Monza, Italia", Tipo = "Autódromo", MejorPilotoId = 20, Seed = true },
                    new Pista { Id = 17, Nombre = "Circuito callejero de Bakú", Ubicacion = "Bakú, Azerbaiyán", Tipo = "Callejero", MejorPilotoId = 3, Seed = true },
                    new Pista { Id = 18, Nombre = "Circuito callejero de Marina Bay", Ubicacion = "Singapur, Singapur", Tipo = "Callejero", MejorPilotoId = 1, Seed = true },
                    new Pista { Id = 19, Nombre = "Circuito de las Américas", Ubicacion = "Austin, EE.UU", Tipo = "Autódromo", MejorPilotoId = 3, Seed = true },
                    new Pista { Id = 20, Nombre = "Autódromo Hermanos Rodríguez", Ubicacion = "Ciudad de México, México", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true },
                    new Pista { Id = 21, Nombre = "Autódromo José Carlos Pace", Ubicacion = "São Paulo, Brasil", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true },
                    new Pista { Id = 22, Nombre = "Circuito de Caesars Palace", Ubicacion = "Las Vegas, EE.UU", Tipo = "Callejero", MejorPilotoId = 5, Seed = true },
                    new Pista { Id = 23, Nombre = "Circuito Internacional de Losail", Ubicacion = "Lusail, Catar", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true },
                    new Pista { Id = 24, Nombre = "Circuito Yas Marina", Ubicacion = "Islas Yas, Abu Dabi", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
