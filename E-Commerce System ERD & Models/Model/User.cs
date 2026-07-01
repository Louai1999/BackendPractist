using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    [Index(nameof(userName), IsUnique = true), Index(nameof(email), IsUnique = true)]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity),Required]
        public int userId { get; set; }// system generated 

        [Required,MaxLength(50)]
        public string userName { get; set; } // user input

        [Required,MaxLength(150)]
        public string email { get; set; } // user input

        [Required,MaxLength(256)]
        public string passwordHash { get; set; } // user input 

        [Required,MaxLength(100)]
        public string fullName { get; set; } // user input 

        [MaxLength(20)]
        public string? phoneNember { get; set; } // user input 

        [MaxLength(300)]
        public string? address { get; set; } // user input

        [Required]
        public DateTime registrationDate { get; set; }//calculated 


        public bool isActive { get; set; } = true;// Defult value 





    }
}
