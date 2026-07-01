using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class Review
    {

        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity),Required]
        public int reviewId { get; set; } // System generated 

        [ForeignKey("userId"),Required]
        public int userId { get; set; } // Foreign key 

        [ForeignKey("productId"),Required]
        public int productId { get; set; } // Foreign Key 

        [Required,Range(1,5)]
        public int rating { get; set; } // Calculated 

        [MaxLength(1000)]
        public string? comment { get; set; } // User input 

        [Required]
        public DateTime reviewDate { get; set; } // Calculated


    }
}
