using System.ComponentModel.DataAnnotations;

namespace FastCartMarketPlace.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Category { get; set; } = "";

        public int StockQuantity { get; set; }

        public string ImageURL { get; set; } = "";
        
        public List<Review>? Reviews { get; set; }

        public List<OrderItem>? OrderItems { get; set; }
    }
}