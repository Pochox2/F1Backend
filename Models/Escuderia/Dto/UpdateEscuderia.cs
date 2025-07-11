using System.ComponentModel.DataAnnotations;


namespace Formula1Backend.Models.Escuderia.Dto
{
    public class UpdateEscuderiaDTO
    {

        [StringLength(50, ErrorMessage = "El nombre de la escuderia no puede exceder los 50 caracteres.")]
        public string? Nombre { get; set; } 

        [StringLength(150, ErrorMessage = "La URL de la imagen no puede exceder los 150 caracteres.")]
        public string? ImagenUrl { get; set; } 

        [StringLength(40, ErrorMessage = "El pais no puede exceder los 40 caracteres.")]
        public string? Pais { get; set; }

        [Range(1800, 2025, ErrorMessage = "El año debe ser valido.")]
        public int? AnoFundacion { get; set; }
    }
}