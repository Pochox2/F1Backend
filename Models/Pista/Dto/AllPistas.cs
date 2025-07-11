namespace Formula1Backend.Models.Pista.Dto
{
    public class AllPistasDTO
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int MejorPilotoId { get; set; }

    }
}