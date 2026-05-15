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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    Name = "Velocity Pro Keyboard",
                    Description = "A responsive mechanical keyboard designed for gaming, coding, and everyday productivity.",
                    Price = 89.99M,
                    Category = "Electronics",
                    StockQuantity = 25,
                    ImageURL = "keyboard.jpg"
                },
                new Product
                {
                    ProductID = 2,
                    Name = "NovaSound Headphones",
                    Description = "Wireless noise-canceling headphones with long battery life and clear audio quality.",
                    Price = 129.99M,
                    Category = "Audio",
                    StockQuantity = 18,
                    ImageURL = "headphones.jpg"
                },
                new Product
                {
                    ProductID = 3,
                    Name = "TitanX Office Chair",
                    Description = "An ergonomic office chair built for comfort during long work or gaming sessions.",
                    Price = 199.99M,
                    Category = "Furniture",
                    StockQuantity = 12,
                    ImageURL = "chair.jpg"
                },
                new Product
                {
                    ProductID = 4,
                    Name = "PulseFit Smartwatch",
                    Description = "A smartwatch that tracks steps, heart rate, notifications, and daily activity goals.",
                    Price = 149.99M,
                    Category = "Wearables",
                    StockQuantity = 30,
                    ImageURL = "smartwatch.jpg"
                }
            );

            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewID = 1,
                    ProductID = 1,
                    CustomerName = "Alex Morgan",
                    Rating = 5,
                    Comment = "Excellent keyboard. The keys feel smooth and responsive."
                },
                new Review
                {
                    ReviewID = 2,
                    ProductID = 1,
                    CustomerName = "Jamie Carter",
                    Rating = 4,
                    Comment = "Great for gaming and schoolwork. Very solid build quality."
                },
                new Review
                {
                    ReviewID = 3,
                    ProductID = 2,
                    CustomerName = "Taylor Brooks",
                    Rating = 5,
                    Comment = "The sound quality is impressive and the battery lasts a long time."
                },
                new Review
                {
                    ReviewID = 4,
                    ProductID = 3,
                    CustomerName = "Jordan Lee",
                    Rating = 4,
                    Comment = "Comfortable chair and easy to assemble."
                }
            );
        }
    }
}