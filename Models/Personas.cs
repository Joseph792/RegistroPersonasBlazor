using System.ComponentModel.DataAnnotations;

namespace RegistroPersonas.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Los Nombres son obligatorios")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El celular es obligatorio")]
        public string? Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "La Direccion es obligatoria")]
        public string? Direccion { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        [Required]
        public int OcupacionId { get; set; }
    }
}