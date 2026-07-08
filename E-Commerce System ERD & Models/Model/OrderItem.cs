using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    internal class OrderItem
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderItemId { get; set; } // System generated

        [Required]
        public int orderId { get; set; } // Foreign Key

        [ForeignKey("orderId")]
        public Order Order { get; set; } // From list

        [Required]
        public int productId { get; set; } // Foreign Key
        [ForeignKey("productId")]
        public Product Product { get; set; } //   User input

        [Required]
        public int quantity { get; set; } //    Calculated 

        [Required, Range(0.1, double.MaxValue)]
        public decimal unitPrice{ get; set; } //Calculated


    }
}
