using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPagos.Fronted.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(12)]
        public string Identificacion { get; set; } = "";

        [Required, MaxLength(100)]
        public string Nombre { get; set; } = "";

        [Required, MaxLength(100)]
        public string Apellido { get; set; } = "";

        public DateTime FechaNacimiento { get; set; }

        [Required, MaxLength(100)]
        public string Contrasena { get; set; } = "";  // texto plano

        [Required, MaxLength(20)]
        public string Rol { get; set; } = "Usuario";

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}