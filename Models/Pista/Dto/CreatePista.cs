using System.ComponentModel.DataAnnotations;

namespace Formula1Backend.Models.Pista.Dto
{
    public class CreatePistaDTO
    {
        [Required(ErrorMessage = "El nombre de la pista es necesario")]
        [StringLength(50, ErrorMessage = "El nombre de la pista no puede exceder los 50 caracteres")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El nombre de la ubicacion es necesario")]
        [StringLength(50, ErrorMessage = "El nombre de la ubicacion no puede exceder los 50 caracteres")]
        public string Ubicacion { get; set; } = null!;

        [Required(ErrorMessage = "El nombre de la ubicacion es necesario")]
        [StringLength(20, ErrorMessage = "El nombre del tipo no puede exceder los 20 caracteres")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El id del piloto con mayor desempeño es necesario")]
        public int MejorPilotoId { get; set; }

        [Required(ErrorMessage = "La imagen de la escuderia es necesaria.")]
        [StringLength(150, ErrorMessage = "La URL de la imagen no puede exceder los 150 caracteres.")]
        public string ImagenUrl { get; set; } = null!;

    }
}
