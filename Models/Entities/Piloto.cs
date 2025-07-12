using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Formula1Backend.Models.Entities
{
    public class Piloto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public int Numero { get; set; }
        public int Edad { get; set; }

        [ForeignKey("Escuderia")]
        public int EscuderiaId { get; set; }
        public Escuderia Escuderia { get; set; } = null!;

        public bool Seed { get; set; } = false;

        public string ImagenUrl { get; set; } = null!;

    }
}