using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FastCartMarketPlace.Migrations
{
    /// <inheritdoc />
    public partial class SeedTwentyFiveProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Description",
                value: "A responsive mechanical keyboard for gaming, coding, and productivity.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Description",
                value: "Wireless noise-canceling headphones with clear audio quality.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Description",
                value: "An ergonomic chair built for comfort during long sessions.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Description",
                value: "A smartwatch for tracking activity, heart rate, and notifications.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Description", "ImageURL", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 5, "Electronics", "Portable battery pack with fast charging for mobile devices.", "powerbank.jpg", "AeroCharge Power Bank", 39.99m, 40 },
                    { 6, "Home Office", "LED desk lamp with adjustable brightness settings.", "lamp.jpg", "EmberGlow Desk Lamp", 34.99m, 22 },
                    { 7, "Computers", "Compact desktop computer for school, work, and streaming.", "minipc.jpg", "FrostByte Mini PC", 449.99m, 8 },
                    { 8, "Accessories", "Adjustable stand for tablets and small laptops.", "tabletstand.jpg", "Horizon Tablet Stand", 24.99m, 55 },
                    { 9, "Electronics", "Comfortable wireless mouse with long battery life.", "mouse.jpg", "Quantum Wireless Mouse", 29.99m, 60 },
                    { 10, "Electronics", "HD webcam for meetings, classes, and streaming.", "webcam.jpg", "ClearView Webcam", 59.99m, 20 },
                    { 11, "Bags", "Durable backpack with padded laptop storage.", "backpack.jpg", "Summit Laptop Backpack", 54.99m, 35 },
                    { 12, "Audio", "USB microphone for podcasts, meetings, and gaming.", "microphone.jpg", "StreamDeck Microphone", 79.99m, 16 },
                    { 13, "Home Office", "Adjustable monitor arm for better desk organization.", "monitorarm.jpg", "CoreFlex Monitor Arm", 69.99m, 14 },
                    { 14, "Accessories", "Large desk mat for keyboards, mice, and workspaces.", "deskmat.jpg", "GlidePad Desk Mat", 19.99m, 75 },
                    { 15, "Accessories", "Charging cable set for phones, tablets, and accessories.", "cables.jpg", "SparkCharge Cable Kit", 17.99m, 90 },
                    { 16, "Audio", "Compact earbuds with charging case and clear sound.", "earbuds.jpg", "EchoBuds Wireless Earbuds", 64.99m, 28 },
                    { 17, "Stationery", "Simple productivity planner for school and work tasks.", "planner.jpg", "BrightNote Planner", 12.99m, 80 },
                    { 18, "Computers", "Cooling pad that helps laptops stay at safer temperatures.", "coolingpad.jpg", "Orbit Laptop Cooling Pad", 31.99m, 26 },
                    { 19, "Lifestyle", "Insulated bottle that keeps drinks cold or hot.", "bottle.jpg", "Metro Stainless Bottle", 22.99m, 65 },
                    { 20, "Lifestyle", "Glasses designed to reduce eye strain during screen time.", "glasses.jpg", "FocusGuard Blue Light Glasses", 18.99m, 45 },
                    { 21, "Home Office", "Comfortable foot rest for improved posture at a desk.", "footrest.jpg", "ZenDesk Foot Rest", 27.99m, 19 },
                    { 22, "Accessories", "Multi-port USB hub for laptops and desktops.", "usbhub.jpg", "RapidLink USB Hub", 25.99m, 50 },
                    { 23, "Computers", "24-inch monitor for work, school, and entertainment.", "monitor.jpg", "PrimeView 24 Monitor", 159.99m, 10 },
                    { 24, "Home", "Soft blanket for home, office, or dorm use.", "blanket.jpg", "CloudSoft Throw Blanket", 29.99m, 32 },
                    { 25, "Accessories", "Adjustable phone mount for desks and video calls.", "phonestand.jpg", "SnapStand Phone Mount", 15.99m, 70 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Description",
                value: "A responsive mechanical keyboard designed for gaming, coding, and everyday productivity.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Description",
                value: "Wireless noise-canceling headphones with long battery life and clear audio quality.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Description",
                value: "An ergonomic office chair built for comfort during long work or gaming sessions.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Description",
                value: "A smartwatch that tracks steps, heart rate, notifications, and daily activity goals.");
        }
    }
}
