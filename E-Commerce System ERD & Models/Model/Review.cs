using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Review
    {
        public int reviewId { get; set; } // System generated 
        public int userId { get; set; } // Foreign key 
        public int productId { get; set; } // Foreign Key 
        public int rating { get; set; } // Calculated 
        public string comment { get; set; } // User input 
        public DateTime reviewDate { get; set; } // Calculated


    }
}
