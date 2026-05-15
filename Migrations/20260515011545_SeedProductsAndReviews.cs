using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FastCartMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsAndReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Description", "ImageURL", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Electronics", "A responsive mechanical keyboard designed for gaming, coding, and everyday productivity.", "keyboard.jpg", "Velocity Pro Keyboard", 89.99m, 25 },
                    { 2, "Audio", "Wireless noise-canceling headphones with long battery life and clear audio quality.", "headphones.jpg", "NovaSound Headphones", 129.99m, 18 },
                    { 3, "Furniture", "An ergonomic office chair built for comfort during long work or gaming sessions.", "chair.jpg", "TitanX Office Chair", 199.99m, 12 },
                    { 4, "Wearables", "A smartwatch that tracks steps, heart rate, notifications, and daily activity goals.", "smartwatch.jpg", "PulseFit Smartwatch", 149.99m, 30 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Comment", "CustomerName", "ProductID", "Rating" },
                values: new object[,]
                {
                    { 1, "Excellent keyboard. The keys feel smooth and responsive.", "Alex Morgan", 1, 5 },
                    { 2, "Great for gaming and schoolwork. Very solid build quality.", "Jamie Carter", 1, 4 },
                    { 3, "The sound quality is impressive and the battery lasts a long time.", "Taylor Brooks", 2, 5 },
                    { 4, "Comfortable chair and easy to assemble.", "Jordan Lee", 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);
        }
    }
}
