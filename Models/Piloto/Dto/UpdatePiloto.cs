using System.ComponentModel.DataAnnotations;


namespace Formula1Backend.Models.Piloto.Dto
{
    public class UpdatePilotoDTO
    {
        
        [StringLength(50, ErrorMessage = "El nombre del piloto no puede exceder los 50 caracteres.")]
        public string? Nombre { get; set; }

        
        [StringLength(50, ErrorMessage = "El pais del piloto no puede exceder los 50 caracteres.")]
        public string? Pais { get; set; }


        
        [Range(1, 100, ErrorMessage = "El numero debe ser valido.")]
        public int? Numero { get; set; }


       
        [Range(18, 100, ErrorMessage = "La edad debe ser valida.")]
        public int? Edad { get; set; }

        
        public int? EscuderiaId { get; set; }


    }
}