using System.ComponentModel.DataAnnotations;

namespace FastCartMarketPlace.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public string CustomerName { get; set; } = "";

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; } = "";

        // Navigation Property
        public Product? Product { get; set; }
    }
}