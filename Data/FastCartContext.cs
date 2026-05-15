using Microsoft.EntityFrameworkCore;
using FastCartMarketPlace.Models;

namespace FastCartMarketPlace.Data
{
    public class FastCartContext : DbContext
    {
        public FastCartContext(DbContextOptions<FastCartContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    }
}