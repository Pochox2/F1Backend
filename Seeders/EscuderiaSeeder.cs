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
                    new Escuderia { Id = 2, Nombre = "McLaren", ImagenUrl = "...", Pais = "Gran Bretaña", AnoFundacion = 1963, Seed = true },
                    new Escuderia { Id = 3, Nombre = "Ferrari", ImagenUrl = "...", Pais = "Italia", AnoFundacion = 1929, Seed = true },
                    new Escuderia { Id = 4, Nombre = "Red Bull", ImagenUrl = "...", Pais = "Austria", AnoFundacion = 2005, Seed = true },
                    new Escuderia { Id = 5, Nombre = "Mercedes", ImagenUrl = "...", Pais = "Gran Bretaña", AnoFundacion = 1954, Seed = true },
                    new Escuderia { Id = 6, Nombre = "Aston Martin", ImagenUrl = "...", Pais = "Inglaterra", AnoFundacion = 1913, Seed = true },
                    new Escuderia { Id = 7, Nombre = "Haas", ImagenUrl = "...", Pais = "Estados Unidos", AnoFundacion = 2016, Seed = true },
                    new Escuderia { Id = 8, Nombre = "Racing Bulls", ImagenUrl = "...", Pais = "Italia", AnoFundacion = 2006, Seed = true },
                    new Escuderia { Id = 9, Nombre = "Williams", ImagenUrl = "...", Pais = "Reino Unido", AnoFundacion = 1977, Seed = true },
                    new Escuderia { Id = 10, Nombre = "Kick Sauber", ImagenUrl = "...", Pais = "Suiza", AnoFundacion = 1993, Seed = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
