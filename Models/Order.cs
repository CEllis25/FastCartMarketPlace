using System.ComponentModel.DataAnnotations;

namespace FastCartMarketPlace.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [Required]
        public string CustomerName { get; set; } = "";

        public DateTime OrderDate { get; set; }

        [Required]
        public string ShippingAddress { get; set; } = "";
        
        public List<OrderItem>? OrderItems { get; set; }
    }
}