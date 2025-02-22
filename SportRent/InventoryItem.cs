using System;

namespace SportRent.Models
{
    public class InventoryItem
    {
        public string Type { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; }
        public string Size { get; set; }  
        public decimal Price { get; set; } 
        public bool IsAvailable { get; set; } 
        public bool HasDiscount { get; set; }

        public override string ToString()
        {
            return $"{Type}: {Name}";
        }
    }
}
