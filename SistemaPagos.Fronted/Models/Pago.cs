using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPagos.Fronted.Models
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        [Required, MaxLength(200)]
        public string Descripcion { get; set; } = "";

        [Required]
        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; } = DateTime.Now;

        // Propiedades de navegación (opcionales)
        public virtual Cliente? Cliente { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}