using System.ComponentModel.DataAnnotations;

namespace ProyectoJubile.Models
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        public string NombreCliente { get; set; } = string.Empty;
        [Required]
        public string ApellidoCliente { get; set; } = string.Empty;
        [Required]
        public string RutCliente { get; set; } = string.Empty;
        [Required]
        public string NacCliente { get; set; } = string.Empty;
        [Required]
        public DateTime FecCliente { get; set; }
        [Required]
        public string AFP { get; set; } = string.Empty;
        [Required]
        public int UF { get; set; }
        [Required]
        public int TelefonoCliente { get; set; }
        [Required]
        public string DireccionCLiente { get; set; } = string.Empty;
        [Required]
        public string CuidadCliente { get; set; } = string.Empty;
        [Required]
        public string Cargo { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Observaciones { get; set; } = string.Empty;
    }
}
