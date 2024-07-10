using InventoryManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Areas.InventorySystem.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string Status { get; set; }
        public bool IsPayment { get; set; }
        public string PaymentType { get; set; }
        public decimal TotalAmount { get; set; }
        public int UserId { get; set; }
        [Key]
        public ApplicationUser User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
