using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Areas.InventorySystem.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();

    }
}
