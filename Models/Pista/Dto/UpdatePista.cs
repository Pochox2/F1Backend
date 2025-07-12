using System.ComponentModel.DataAnnotations;


namespace Formula1Backend.Models.Pista.Dto
{
    public class UpdatePistaDTO
    {

        [StringLength(50, ErrorMessage = "El nombre de la pista no puede exceder los 50 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(50, ErrorMessage = "El nombre de la ubicacion no puede exceder los 50 caracteres")]
        public string? Ubicacion { get; set; }


        [StringLength(20, ErrorMessage = "El nombre del tipo no puede exceder los 20 caracteres")]
        public string? Tipo { get; set; }

       
        public int? MejorPilotoId { get; set; }


    }
}
