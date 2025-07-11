namespace Formula1Backend.Models.Piloto.Dto
{
	public class AllPilotosDTO
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = null!;
		public string Pais { get; set; } = null!;
		public int Numero { get; set; }
		public int Edad { get; set; }
		public int EscuderiaId { get; set; }


	}
}