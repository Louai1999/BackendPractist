using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace university.universityModel
{
    [Index(nameof(email), IsUnique = true)]
    public class Instructor
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int instructorId { get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // User input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User input


        [MaxLength(20)]
        public string? officeNamber { get; set; } // From list


        [Required]
        public DateTime hireDate { get; set; } // User input


        [Required]
        [Range(0, double.MaxValue)]
        public decimal salary { get; set; } = 0m;// User input

        [Required]
        [MaxLength(50)]
        public string academicTitle { get; set; } // user input 




        //Relationships
        [ForeignKey("User")]
        public int departmentId { get; set; } // Foreign key property 
        public Department department { get; set; } // Navigation property 

        public ICollection<Course> Courses { get; set; } // Navigation property





    }
}
