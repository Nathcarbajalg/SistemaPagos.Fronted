using Microsoft.EntityFrameworkCore;

namespace SistemaPagos.Fronted.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cambia la cadena según tu servidor (LocalDB, SQLEXPRESS, etc.)
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=SistemaPagosDB;Trusted_Connection=True;;");
        }
    }
}