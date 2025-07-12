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
                    new Pista { Id = 1, Nombre = "Circuito Internacional de Baréin", Ubicacion = "Sakhir, Baréin", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/2/29/Bahrain_International_Circuit--Grand_Prix_Layout.svg" },
                    new Pista { Id = 2, Nombre = "Circuito de la Corniche de Jeddah", Ubicacion = "Yeda, Arabia Saudita", Tipo = "Híbrido", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4c/Jeddah_Street_Circuit_2021.svg" },
                    new Pista { Id = 3, Nombre = "Circuito de Albert Park", Ubicacion = "Melbourne, Australia", Tipo = "Híbrido", MejorPilotoId = 3, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0a/Albert_Park_Circuit_2021.svg" },
                    new Pista { Id = 4, Nombre = "Circuito Internacional de Shanghái", Ubicacion = "Shanghái, China", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/1/14/Shanghai_International_Racing_Circuit_track_map.svg" },
                    new Pista { Id = 5, Nombre = "Circuito de Suzuka", Ubicacion = "Suzuka - Mie, Japón", Tipo = "Autódromo", MejorPilotoId = 8, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Suzuka_circuit_map--2005.svg" },
                    new Pista { Id = 6, Nombre = "Autódromo Internacional de Miami", Ubicacion = "Miami, EE.UU", Tipo = "Híbrido", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/4/49/Hard_Rock_Stadium_Circuit_2022.svg" },
                    new Pista { Id = 7, Nombre = "Autodromo Enzo e Dino Ferrari", Ubicacion = "Imola, Italia", Tipo = "Autódromo", MejorPilotoId = 18, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/2/22/Imola_2009.svg" },
                    new Pista { Id = 8, Nombre = "Circuito de Monaco", Ubicacion = "Montecarlo, Mónaco", Tipo = "Callejero", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/3/36/Monte_Carlo_Formula_1_track_map.svg" },
                    new Pista { Id = 9, Nombre = "Circuito de Barcelona-Cataluña", Ubicacion = "Montmeló - Barcelona, Cataluña", Tipo = "Autódromo", MejorPilotoId = 8, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Circuit_de_Catalunya_moto_2021.svg/1200px-Circuit_de_Catalunya_moto_2021.svg.png" },
                    new Pista { Id = 10, Nombre = "Circuito Gilles Villeneuve", Ubicacion = "Montreal, Canadá", Tipo = "Híbrido", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/2/21/Circuit_Gilles_Villeneuve.svg" },
                    new Pista { Id = 11, Nombre = "Red Bull Ring", Ubicacion = "Spielberg, Austria", Tipo = "Autódromo", MejorPilotoId = 3, Seed = true, ImagenUrl = "https://lebalap.academy/wp-content/uploads/2021/02/image-1-1.png" },
                    new Pista { Id = 12, Nombre = "Circuito de Silverstone", Ubicacion = "Inglaterra, Reino Unido", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Circuit_Silverstone_2011.svg" },
                    new Pista { Id = 13, Nombre = "Circuit de spa-Francorchamps", Ubicacion = "Francorchamps, Lieja, Bélgica", Tipo = "Híbrido", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Spa-Francorchamps_of_Belgium.svg/1200px-Spa-Francorchamps_of_Belgium.svg.png" },
                    new Pista { Id = 14, Nombre = "Pista: Hungaroring", Ubicacion = "Mogyoród, Hungría", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Hungaroring.svg" },
                    new Pista { Id = 15, Nombre = "Circuito de Zandvoordt", Ubicacion = "Zandvoordt, Países Bajos", Tipo = "Autódromo", MejorPilotoId = 4, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Zandvoort_Circuit.png/1200px-Zandvoort_Circuit.png" },
                    new Pista { Id = 16, Nombre = "Autodromo Nazionale di monza", Ubicacion = "Monza, Italia", Tipo = "Autódromo", MejorPilotoId = 20, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f8/Monza_track_map.svg" },
                    new Pista { Id = 17, Nombre = "Circuito callejero de Bakú", Ubicacion = "Bakú, Azerbaiyán", Tipo = "Callejero", MejorPilotoId = 3, Seed = true, ImagenUrl = "https://lebalap.academy/wp-content/uploads/2021/02/image-1.png" },
                    new Pista { Id = 18, Nombre = "Circuito callejero de Marina Bay", Ubicacion = "Singapur, Singapur", Tipo = "Callejero", MejorPilotoId = 1, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8b/Marina_Bay_circuit_2023.svg" },
                    new Pista { Id = 19, Nombre = "Circuito de las Américas", Ubicacion = "Austin, EE.UU", Tipo = "Autódromo", MejorPilotoId = 3, Seed = true, ImagenUrl = "https://lebalap.academy/wp-content/uploads/2021/02/image-2-1.png" },
                    new Pista { Id = 20, Nombre = "Autódromo Hermanos Rodríguez", Ubicacion = "Ciudad de México, México", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true, ImagenUrl = "https://lebalap.academy/wp-content/uploads/2021/02/image-1-3.png" },
                    new Pista { Id = 21, Nombre = "Autódromo José Carlos Pace", Ubicacion = "São Paulo, Brasil", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Aut%C3%B3dromo_Jos%C3%A9_Carlos_Pace_%28AKA_Interlagos%29_track_map.svg" },
                    new Pista { Id = 22, Nombre = "Circuito de Caesars Palace", Ubicacion = "Las Vegas, EE.UU", Tipo = "Callejero", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Circuit_Caesars_Palace.png" },
                    new Pista { Id = 23, Nombre = "Circuito Internacional de Losail", Ubicacion = "Lusail, Catar", Tipo = "Autódromo", MejorPilotoId = 1, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Lusail_International_Circuit_2023.svg/1200px-Lusail_International_Circuit_2023.svg.png" },
                    new Pista { Id = 24, Nombre = "Circuito Yas Marina", Ubicacion = "Islas Yas, Abu Dabi", Tipo = "Autódromo", MejorPilotoId = 5, Seed = true, ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b0/Yas_Marina_Circuit.png/1200px-Yas_Marina_Circuit.png" }
                    );
                context.SaveChanges();
            }
        }
    }
}
