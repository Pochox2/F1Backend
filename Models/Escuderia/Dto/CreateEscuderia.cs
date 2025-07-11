using System.ComponentModel.DataAnnotations;

namespace Formula1Backend.Models.Escuderia.Dto
{
    public class CreateEscuderiaDTO
    { 

        [Required(ErrorMessage = "El nombre de la escuderia es necesario.")]
        [StringLength(50, ErrorMessage = "El nombre de la escuderia no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La imagen de la escuderia es necesaria.")]
        [StringLength(150, ErrorMessage = "La URL de la imagen no puede exceder los 150 caracteres.")]
        public string ImagenUrl { get; set; } = null!;

        [Required(ErrorMessage = "El pais de la escuderia es obligatorio.")]
        [StringLength(40, ErrorMessage = "El pais no puede exceder los 40 caracteres.")]
        public string Pais { get; set;} = null!;

        [Required(ErrorMessage = "Debe especificar el año de fundacion.")]
        [Range(1800, 2025, ErrorMessage = "El año debe ser valido.")]
        public int AñoFundacion { get; set;}

    }
}