using System.ComponentModel.DataAnnotations;

namespace Formula1Backend.Models.Piloto.Dto
{
    public class CreatePilotoDTO
    {
        [Required(ErrorMessage = "El nombre del piloto es necesario.")]
        [StringLength(50, ErrorMessage = "El nombre del piloto no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El pais del piloto es necesario.")]
        [StringLength(50, ErrorMessage = "El pais del piloto no puede exceder los 50 caracteres.")]
        public string Pais { get; set; } = null!;


        [Required(ErrorMessage = "Debe especificar el numero del piloto.")]
        [Range(1, 100, ErrorMessage = "El numero debe ser valido.")]
        public int Numero { get; set; }


        [Required(ErrorMessage = "Debe especificar la edad del piloto.")]
        [Range(18, 100, ErrorMessage = "La edad debe ser valida.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Debe especificar el id de la escuderia del piloto.")]
        public int EscuderiaId { get; set; }

        [Required(ErrorMessage = "La imagen de la escuderia es necesaria.")]
        [StringLength(150, ErrorMessage = "La URL de la imagen no puede exceder los 150 caracteres.")]
        public string ImagenUrl { get; set; } = null!;


    }
}