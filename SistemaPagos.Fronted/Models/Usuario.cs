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

        [Required]
        [Column("Identificacion")]
        [StringLength(12, MinimumLength = 12)]
        public string Identificacion { get; set; } = string.Empty;

        [Required]
        [Column("Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column("Apellido")]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [Column("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Column("Contrasena")]
        [StringLength(100)]
        public string Contrasena { get; set; } = string.Empty;

        [Column("Rol")]
        [StringLength(20)]
        public string Rol { get; set; } = "Usuario";

        [Column("FechaRegistro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}