using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Order
    {

        public int orderId { get; set; }//System generated 
        public int userId { get; set; } // Foreign key
        public DateTime orderDate { get; set; } // Calculated 
        public decimal totalAmount { get; set; } // Calculated 
        public string status { get; set; } //Defult value 
        public string shippingAddress { get; set; } // User input 
        public string paymentMethod { get; set; }// Calculated 
    }
}
