using StoreDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace StoreDatabase.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "Screwdriver", UnitPrice = 4.99f },
                    new Product { Id = 2, Name = "Hammer", UnitPrice = 6.99f },
                    new Product { Id = 3, Name = "Drill", UnitPrice = 59.99f },
                    new Product { Id = 4, Name = "Circular Saw", UnitPrice = 49.99f },
                    new Product { Id = 5, Name = "Table Saw", UnitPrice = 399.99f }
                );
           
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

    }

}
