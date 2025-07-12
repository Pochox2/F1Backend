using Formula1Backend.Config;
using Formula1Backend.Models.Entities;


namespace Formula1Backend.Seeders
{
    public static class EscuderiaSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if(!context.Escuderias.Any())
            {
                context.Escuderias.AddRange(
                    new Escuderia { Id = 1, Nombre = "Alpine", ImagenUrl = "https://download.logo.wine/logo/Alpine_(automobile)/Alpine_(automobile)-Logo.wine.png", Pais = "Francia", AnoFundacion = 1939, Seed = true },
                    new Escuderia { Id = 2, Nombre = "McLaren", ImagenUrl = "https://w7.pngwing.com/pngs/428/243/png-transparent-mclaren-racing-hd-logo.png", Pais = "Gran Bretaña", AnoFundacion = 1963, Seed = true },
                    new Escuderia { Id = 3, Nombre = "Ferrari", ImagenUrl = "https://c0.klipartz.com/pngpicture/14/576/gratis-png-ilustracion-del-logotipo-de-ferrari-logotipo-del-emblema-de-ferrari.png", Pais = "Italia", AnoFundacion = 1929, Seed = true },
                    new Escuderia { Id = 4, Nombre = "Red Bull", ImagenUrl = "https://e7.pngegg.com/pngimages/243/428/png-clipart-red-bull-racing-team-red-bull-gmbh-red-bull-simply-cola-red-bull-text-carnivoran.png", Pais = "Austria", AnoFundacion = 2005, Seed = true },
                    new Escuderia { Id = 5, Nombre = "Mercedes", ImagenUrl = "https://w7.pngwing.com/pngs/366/779/png-transparent-mercedes-benz-logo-car-daimler-ag-mercedes-amg-petronas-f1-team-mercedes-benz-angle-emblem-trademark.png", Pais = "Gran Bretaña", AnoFundacion = 1954, Seed = true },
                    new Escuderia { Id = 6, Nombre = "Aston Martin", ImagenUrl = "https://www.pngfind.com/pngs/m/133-1336044_the-gallery-for-aston-martin-logo-png-aston.png", Pais = "Inglaterra", AnoFundacion = 1913, Seed = true },
                    new Escuderia { Id = 7, Nombre = "Haas", ImagenUrl = "https://e7.pngegg.com/pngimages/862/18/png-clipart-haas-f1-team-mercedes-amg-petronas-f1-team-formula-one-esports-series-racing-point-force-india-f1-formula-one-team-haas-f1-team-mercedes-amg-petronas-f1-team.png", Pais = "Estados Unidos", AnoFundacion = 2016, Seed = true },
                    new Escuderia { Id = 8, Nombre = "Racing Bulls", ImagenUrl = "https://e7.pngegg.com/pngimages/571/568/png-clipart-red-bull-racing-team-formula-1-red-bull-arena-leipzig-red-bull-text-racing.png", Pais = "Italia", AnoFundacion = 2006, Seed = true },
                    new Escuderia { Id = 9, Nombre = "Williams", ImagenUrl = "https://e7.pngegg.com/pngimages/754/329/png-clipart-williams-martini-racing-red-bull-racing-2016-formula-one-world-championship-williams-fw37-abu-dhabi-grand-prix-car-blue-angle.png", Pais = "Reino Unido", AnoFundacion = 1977, Seed = true },
                    new Escuderia { Id = 10, Nombre = "Kick Sauber", ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Stake_F1_Team_logo.png", Pais = "Suiza", AnoFundacion = 1993, Seed = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
