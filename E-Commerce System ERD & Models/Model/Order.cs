using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Order
    {

        public int orderId { get; set; }
        public int userId { get; set; }
        public DateTime orderDate { get; set; }
        public decimal totalAmount { get; set; }
        public string status { get; set; }
        public string shippingAddress { get; set; } 
        public string paymentMethod { get; set; }
    }
}
