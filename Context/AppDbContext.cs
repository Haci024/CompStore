using CompStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompStore.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CompStoreDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderComputer> OrderComputers { get; set; }
    }
}
