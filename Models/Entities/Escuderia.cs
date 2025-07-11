
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Formula1Backend.Models.Entities
{
	public class Escuderia
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Nombre { get; set;} = null!;
		public string ImagenUrl { get; set; } = null!;
		public string Pais { get; set; } = null!;
		public int AñoFundacion { get; set; }

        public bool Seed { get; set; } = false;

        public List<Piloto> Pilotos { get; set; } = new();

	}
}