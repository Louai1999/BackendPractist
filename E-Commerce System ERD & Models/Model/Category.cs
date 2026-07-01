using System;
using Microsoft.EntityFrameworkCore;//unique
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    [Index(nameof(categoryName), IsUnique = true)]//unique
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto-generated
        [Required]
        public int categoryId {  get; set; } // System generated 

        [Required,MaxLength(50),]
        public string categoryName { get; set; } // User input

        [MaxLength(500)]
        public string? description { get; set; } // user input 

        [MaxLength(300)]
        public string? imageUrl { get; set; }//User input




    }
}
