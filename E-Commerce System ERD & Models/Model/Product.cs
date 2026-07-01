using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public int stockQuantity { get; set; }
        public string imageUrl { get; set; }
        public int categoryId { get; set; }
        public DateTime createdAt { get; set; }
        public bool isAvailable { get; set; }


    }
}
