using InventoryManagementSystem.Areas.InventorySystem.Models;
using Microsoft.AspNetCore.Identity;

namespace InventoryManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
