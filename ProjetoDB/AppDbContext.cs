using Microsoft.EntityFrameworkCore;
using ProjetoDB.Models; // Importante: aponta para a pasta Models

namespace ProjetoDB
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ExampleDB;User Id=sa;Password=V0ucomerfrut@;TrustServerCertificate=True");
        }
    }
}