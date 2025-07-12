using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Formula1Backend.Models.Entities
{
    public class Pista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        [ForeignKey("Piloto")]
        public int MejorPilotoId { get; set; }
        public Piloto MejorPiloto { get; set; } = null!;
        public bool Seed { get; set; } = false;

        public string ImagenUrl { get; set; } = null!;


    }
}