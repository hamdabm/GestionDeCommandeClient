
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.GestionDeCommandeContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CommandeEntete> CommandeEntetes { get; set; }
        public DbSet<CommandeLigne> CommandeLignes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
