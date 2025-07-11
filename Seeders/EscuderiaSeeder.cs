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
                    new Escuderia { Id = 1, Nombre = "Alpine", ImagenUrl = "...", Pais = "Francia", AñoFundacion = 1939, Seed = true },
                    new Escuderia { Id = 2, Nombre = "McLaren", ImagenUrl = "...", Pais = "Gran Bretaña", AñoFundacion = 1963, Seed = true },
                    new Escuderia { Id = 3, Nombre = "Ferrari", ImagenUrl = "...", Pais = "Italia", AñoFundacion = 1929, Seed = true },
                    new Escuderia { Id = 4, Nombre = "Red Bull", ImagenUrl = "...", Pais = "Austria", AñoFundacion = 2005, Seed = true },
                    new Escuderia { Id = 5, Nombre = "Mercedes", ImagenUrl = "...", Pais = "Gran Bretaña", AñoFundacion = 1954, Seed = true },
                    new Escuderia { Id = 6, Nombre = "Aston Martin", ImagenUrl = "...", Pais = "Inglaterra", AñoFundacion = 1913, Seed = true },
                    new Escuderia { Id = 7, Nombre = "Haas", ImagenUrl = "...", Pais = "Estados Unidos", AñoFundacion = 2016, Seed = true },
                    new Escuderia { Id = 8, Nombre = "Racing Bulls", ImagenUrl = "...", Pais = "Italia", AñoFundacion = 2006, Seed = true },
                    new Escuderia { Id = 9, Nombre = "Williams", ImagenUrl = "...", Pais = "Reino Unido", AñoFundacion = 1977, Seed = true },
                    new Escuderia { Id = 10, Nombre = "Kick Sauber", ImagenUrl = "...", Pais = "Suiza", AñoFundacion = 1993, Seed = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
