using Formula1Backend.Config;
using Formula1Backend.Models.Entities;

namespace Formula1Backend.Seeders
{
    public static class PilotoSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Pilotos.Any())
            {
                context.Pilotos.AddRange(
                    new Piloto { Id = 1, Nombre = "Lando Norris", Pais = "Reino Unido", Numero = 4, Edad = 24, EscuderiaId = 2, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/lnorris_2025.png" },
                    new Piloto { Id = 2, Nombre = "Oscar Piastri", Pais = "Australia", Numero = 81, Edad = 23, EscuderiaId = 2, Seed = true, ImagenUrl = "https://a.espncdn.com/combiner/i?img=/i/headshots/rpm/players/full/5752.png&w=350&h=254" },
                    new Piloto { Id = 3, Nombre = "Charles Leclerc", Pais = "Mónaco", Numero = 16, Edad = 26, EscuderiaId = 3, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/cleclerc_2025.png" },
                    new Piloto { Id = 4, Nombre = "Lewis Hamilton", Pais = "Reino Unido", Numero = 44, Edad = 40, EscuderiaId = 3, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/lhamilton_2025.png" },
                    new Piloto { Id = 5, Nombre = "Max Verstappen", Pais = "Países Bajos", Numero = 1, Edad = 27, EscuderiaId = 4, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/mverstappen_2025.png" },
                    new Piloto { Id = 6, Nombre = "Yuki Tsunoda", Pais = "Japón", Numero = 22, Edad = 24, EscuderiaId = 4, Seed = true, ImagenUrl = "https://a.espncdn.com/combiner/i?img=/i/headshots/rpm/players/full/5652.png&w=350&h=254" },
                    new Piloto { Id = 7, Nombre = "George Russell", Pais = "Reino Unido", Numero = 63, Edad = 26, EscuderiaId = 5, Seed = true, ImagenUrl = "https://a.espncdn.com/combiner/i?img=/i/headshots/rpm/players/full/5503.png&w=350&h=254" },
                    new Piloto { Id = 8, Nombre = "Kimi Antonelli", Pais = "Italia", Numero = 12, Edad = 18, EscuderiaId = 5, Seed = true, ImagenUrl = "https://cdn.racingnews365.com/_570x570_crop_center-center_none/andant01.png?v=1741599652" },
                    new Piloto { Id = 9, Nombre = "Fernando Alonso", Pais = "España", Numero = 14, Edad = 43, EscuderiaId = 6, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/falonso_2025.png" },
                    new Piloto { Id = 10, Nombre = "Lance Stroll", Pais = "Canadá", Numero = 18, Edad = 26, EscuderiaId = 6, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyNC9kcml2ZXJzL2hlYWRzaG90cy9mMS9zdHIucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" },
                    new Piloto { Id = 11, Nombre = "Pierre Gasly", Pais = "Francia", Numero = 10, Edad = 28, EscuderiaId = 1, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyNC9kcml2ZXJzL2hlYWRzaG90cy9mMS9nYXMucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" },
                    new Piloto { Id = 12, Nombre = "Franco Colapinto", Pais = "Argentina", Numero = 43, Edad = 21, EscuderiaId = 1, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-05/franco-colapinto-2025-soymotor.png" },
                    new Piloto { Id = 13, Nombre = "Oliver Bearman", Pais = "Reino Unido", Numero = 87, Edad = 20, EscuderiaId = 7, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/obearman_2025.png" },
                    new Piloto { Id = 14, Nombre = "Esteban Ocon", Pais = "Francia", Numero = 31, Edad = 27, EscuderiaId = 7, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/eocon_2025.png" },
                    new Piloto { Id = 15, Nombre = "Liam Lawson", Pais = "Nueva Zelanda", Numero = 30, Edad = 23, EscuderiaId = 8, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyMy9kcml2ZXJzL2hlYWRzaG90cy9mMS9sYXcucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" },
                    new Piloto { Id = 16, Nombre = "Isack Hadjar", Pais = "Francia", Numero = 6, Edad = 20, EscuderiaId = 8, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyNC9kcml2ZXJzL2hlYWRzaG90cy9mMi9oYWQucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" },
                    new Piloto { Id = 17, Nombre = "Alexander Albon", Pais = "Reino Unido", Numero = 23, Edad = 29, EscuderiaId = 9, Seed = true, ImagenUrl = "https://cdn.williamsf1.tech/images/fnx611yr/production/eee45bf4f4cfcebfee0596db9eb74bda1b86a1c5-3136x3135.png?rect=0,0,3135,3135&w=625&h=625&auto=format" },
                    new Piloto { Id = 18, Nombre = "Carlos Sainz", Pais = "España", Numero = 55, Edad = 30, EscuderiaId = 9, Seed = true, ImagenUrl = "https://soymotor.com/sites/default/files/2025-03/csainz_2025.png" },
                    new Piloto { Id = 19, Nombre = "Nico Hülkenberg", Pais = "Alemania", Numero = 27, Edad = 37, EscuderiaId = 10, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyMy9kcml2ZXJzL2hlYWRzaG90cy9mMS9odWwucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" },
                    new Piloto { Id = 20, Nombre = "Gabriel Bortoleto", Pais = "Brasil", Numero = 5, Edad = 20, EscuderiaId = 10, Seed = true, ImagenUrl = "https://image-service.zaonce.net/eyJidWNrZXQiOiJmcm9udGllci1jbXMiLCJrZXkiOiJmMW1hbmFnZXIvMjAyMy9kcml2ZXJzL2hlYWRzaG90cy9mMy9ib3IucG5nIiwiZWRpdHMiOnsicmVzaXplIjp7IndpZHRoIjo1MDB9fX0=" }
                );
                context.SaveChanges();
            }
        }
    }
}
