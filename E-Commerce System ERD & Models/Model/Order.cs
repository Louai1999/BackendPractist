using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Order
    {


        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; } // System generated 

        [Required]
        public DateTime orderDate { get; set; } // Calculated 

        [Required, Range(0, double.MaxValue)]
        public decimal totalAmount { get; set; } // Calculated 

        [Required, MaxLength(30)]
        public string status { get; set; } = "Pending"; // Default value 

        [Required, MaxLength(300)]
        public string shippingAddress { get; set; } // User input 

        [Required, MaxLength(50)]
        public string paymentMethod { get; set; } // Calculated




        //Relationship 
        [ForeignKey("User")]
        public int userId { get; set; } // Foreign key property 
        public User User { get; set; } //Navigation property

        public ICollection<OrderItem> orderItemId { get; set; } // Navigation property 



    }
}
