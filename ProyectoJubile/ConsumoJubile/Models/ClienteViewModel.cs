using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumoJubile.Models
{
    public class ClienteViewModel
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        [DisplayName("Nombre Cliente")]
        public string NombreCliente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Apellido Cliente")]
        public string ApellidoCliente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Rut Cliente")]
        public string RutCliente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Nacionalidad")]
        public string NacCliente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FecCliente { get; set; }
        [Required]
        [DisplayName("AFP")]
        public string AFP { get; set; } = string.Empty;
        [Required]
        [DisplayName("UF")]
        public int UF { get; set; }
        [Required]
        [DisplayName("Telefono")]
        public int TelefonoCliente { get; set; }
        [Required]
        [DisplayName("Direccion")]
        public string DireccionCLiente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Cuidad")]
        public string CuidadCliente { get; set; } = string.Empty;
        [Required]
        [DisplayName("Cargo")]
        public string Cargo { get; set; } = string.Empty;
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DisplayName("Observaciones")]
        public string Observaciones { get; set; } = string.Empty;
    }
}
