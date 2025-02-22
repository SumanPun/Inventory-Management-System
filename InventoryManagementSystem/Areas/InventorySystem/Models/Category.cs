﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Areas.InventorySystem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
