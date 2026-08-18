using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Product
    {

        [Key ,DatabaseGenerated(DatabaseGeneratedOption .Identity),Required]
        public int productId { get; set; } // System generated 


        [Required , MaxLength(150)]
        public string productName { get; set; } // User input 


        [MaxLength(1000)]
        public string? description { get; set; } // User input 


        [Required, Range(0.1, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal price { get; set; } // Calculated 


        [Required, Range(0, int.MaxValue)]
        public int stockQuantity { get; set; } = 0; // Calculated 

        [MaxLength(300)]
        public string? imageUrl { get; set; } // User input
//
        //[ForeignKey("categoryId"),Required]
       // public int categoryId { get; set; } // Foreign key 

        [Required]
        public DateTime createdAt { get; set; } // Calcilated


        public bool isAvailable { get; set; } = true; // Defualt value 


        //Relationship

        public ICollection<Order> orders { get; set; } // Navigation property 


        [ForeignKey("category")]
        public int categoryId { get; set; } // Foreign key property 
        public Category Category { get; set; } // Navigation property

        public ICollection<OrderItem> OrderItems { get; set; }

        public ICollection<Review> reviews { get; set; } // Navigation property 



    }
}
