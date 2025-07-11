using Formula1Backend.Config;

namespace Formula1Backend.Seeders
{
    public static class DataSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            EscuderiaSeeder.Seed(context);
            PilotoSeeder.Seed(context);
            PistaSeeder.Seed(context);
        }
    }
}
