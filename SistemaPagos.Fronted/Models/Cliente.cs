using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPagos.Fronted.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(12)]
        public string Identificacion { get; set; } = "";

        [Required, MaxLength(200)]
        public string NombreCompleto { get; set; } = "";

        [MaxLength(100)]
        public string? Correo { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }
    }
}