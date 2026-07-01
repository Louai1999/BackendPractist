using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Product
    {
        public int productId { get; set; } // System generated 
        public string productName { get; set; } // User input 
        public string description { get; set; } // User input 
        public decimal price { get; set; } // Calculated 
        public int stockQuantity { get; set; } // Calculated 
        public string imageUrl { get; set; } // User input
        public int categoryId { get; set; } // Foreign key 
        public DateTime createdAt { get; set; } // Calcilated
        public bool isAvailable { get; set; } // Defualt value 


    }
}
