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
    new Product { ProductID = 1, Name = "Velocity Pro Keyboard", Description = "A responsive mechanical keyboard for gaming, coding, and productivity.", Price = 89.99M, Category = "Electronics", StockQuantity = 25, ImageURL = "keyboard.jpg" },
    new Product { ProductID = 2, Name = "NovaSound Headphones", Description = "Wireless noise-canceling headphones with clear audio quality.", Price = 129.99M, Category = "Audio", StockQuantity = 18, ImageURL = "headphones.jpg" },
    new Product { ProductID = 3, Name = "TitanX Office Chair", Description = "An ergonomic chair built for comfort during long sessions.", Price = 199.99M, Category = "Furniture", StockQuantity = 12, ImageURL = "chair.jpg" },
    new Product { ProductID = 4, Name = "PulseFit Smartwatch", Description = "A smartwatch for tracking activity, heart rate, and notifications.", Price = 149.99M, Category = "Wearables", StockQuantity = 30, ImageURL = "smartwatch.jpg" },
    new Product { ProductID = 5, Name = "AeroCharge Power Bank", Description = "Portable battery pack with fast charging for mobile devices.", Price = 39.99M, Category = "Electronics", StockQuantity = 40, ImageURL = "powerbank.jpg" },
    new Product { ProductID = 6, Name = "EmberGlow Desk Lamp", Description = "LED desk lamp with adjustable brightness settings.", Price = 34.99M, Category = "Home Office", StockQuantity = 22, ImageURL = "lamp.jpg" },
    new Product { ProductID = 7, Name = "FrostByte Mini PC", Description = "Compact desktop computer for school, work, and streaming.", Price = 449.99M, Category = "Computers", StockQuantity = 8, ImageURL = "minipc.jpg" },
    new Product { ProductID = 8, Name = "Horizon Tablet Stand", Description = "Adjustable stand for tablets and small laptops.", Price = 24.99M, Category = "Accessories", StockQuantity = 55, ImageURL = "tabletstand.jpg" },
    new Product { ProductID = 9, Name = "Quantum Wireless Mouse", Description = "Comfortable wireless mouse with long battery life.", Price = 29.99M, Category = "Electronics", StockQuantity = 60, ImageURL = "mouse.jpg" },
    new Product { ProductID = 10, Name = "ClearView Webcam", Description = "HD webcam for meetings, classes, and streaming.", Price = 59.99M, Category = "Electronics", StockQuantity = 20, ImageURL = "webcam.jpg" },
    new Product { ProductID = 11, Name = "Summit Laptop Backpack", Description = "Durable backpack with padded laptop storage.", Price = 54.99M, Category = "Bags", StockQuantity = 35, ImageURL = "backpack.jpg" },
    new Product { ProductID = 12, Name = "StreamDeck Microphone", Description = "USB microphone for podcasts, meetings, and gaming.", Price = 79.99M, Category = "Audio", StockQuantity = 16, ImageURL = "microphone.jpg" },
    new Product { ProductID = 13, Name = "CoreFlex Monitor Arm", Description = "Adjustable monitor arm for better desk organization.", Price = 69.99M, Category = "Home Office", StockQuantity = 14, ImageURL = "monitorarm.jpg" },
    new Product { ProductID = 14, Name = "GlidePad Desk Mat", Description = "Large desk mat for keyboards, mice, and workspaces.", Price = 19.99M, Category = "Accessories", StockQuantity = 75, ImageURL = "deskmat.jpg" },
    new Product { ProductID = 15, Name = "SparkCharge Cable Kit", Description = "Charging cable set for phones, tablets, and accessories.", Price = 17.99M, Category = "Accessories", StockQuantity = 90, ImageURL = "cables.jpg" },
    new Product { ProductID = 16, Name = "EchoBuds Wireless Earbuds", Description = "Compact earbuds with charging case and clear sound.", Price = 64.99M, Category = "Audio", StockQuantity = 28, ImageURL = "earbuds.jpg" },
    new Product { ProductID = 17, Name = "BrightNote Planner", Description = "Simple productivity planner for school and work tasks.", Price = 12.99M, Category = "Stationery", StockQuantity = 80, ImageURL = "planner.jpg" },
    new Product { ProductID = 18, Name = "Orbit Laptop Cooling Pad", Description = "Cooling pad that helps laptops stay at safer temperatures.", Price = 31.99M, Category = "Computers", StockQuantity = 26, ImageURL = "coolingpad.jpg" },
    new Product { ProductID = 19, Name = "Metro Stainless Bottle", Description = "Insulated bottle that keeps drinks cold or hot.", Price = 22.99M, Category = "Lifestyle", StockQuantity = 65, ImageURL = "bottle.jpg" },
    new Product { ProductID = 20, Name = "FocusGuard Blue Light Glasses", Description = "Glasses designed to reduce eye strain during screen time.", Price = 18.99M, Category = "Lifestyle", StockQuantity = 45, ImageURL = "glasses.jpg" },
    new Product { ProductID = 21, Name = "ZenDesk Foot Rest", Description = "Comfortable foot rest for improved posture at a desk.", Price = 27.99M, Category = "Home Office", StockQuantity = 19, ImageURL = "footrest.jpg" },
    new Product { ProductID = 22, Name = "RapidLink USB Hub", Description = "Multi-port USB hub for laptops and desktops.", Price = 25.99M, Category = "Accessories", StockQuantity = 50, ImageURL = "usbhub.jpg" },
    new Product { ProductID = 23, Name = "PrimeView 24 Monitor", Description = "24-inch monitor for work, school, and entertainment.", Price = 159.99M, Category = "Computers", StockQuantity = 10, ImageURL = "monitor.jpg" },
    new Product { ProductID = 24, Name = "CloudSoft Throw Blanket", Description = "Soft blanket for home, office, or dorm use.", Price = 29.99M, Category = "Home", StockQuantity = 32, ImageURL = "blanket.jpg" },
    new Product { ProductID = 25, Name = "SnapStand Phone Mount", Description = "Adjustable phone mount for desks and video calls.", Price = 15.99M, Category = "Accessories", StockQuantity = 70, ImageURL = "phonestand.jpg" }
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