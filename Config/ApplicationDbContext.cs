using Formula1Backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Formula1Backend.Config
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Escuderia> Escuderias { get; set; } = null!;
        public DbSet<Piloto> Pilotos { get; set; } = null!;

        public DbSet<Pista> Pistas { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Escuderia>()
                .HasIndex(e => e.Nombre)
                .IsUnique();

            modelBuilder.Entity<Escuderia>()
                .HasMany(e => e.Pilotos)
                .WithOne(p => p.Escuderia)
                .HasForeignKey(p => p.EscuderiaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Pista>()
                .HasOne(p => p.MejorPiloto)
                .WithMany()
                .HasForeignKey(p => p.MejorPilotoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
