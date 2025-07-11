

namespace Formula1Backend.Models.Escuderia.Dto
{
	public class AllEscuderiasDTO
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;
		public string ImagenUrl { get; set; } = null!;
		public string Pais { get; set; } = null!;
		public int AñoFundacion { get; set; }
	}
}