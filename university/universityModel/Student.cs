using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Text;

namespace university.universityModel
{
    [Index(nameof(email), IsUnique = true)]
    public class Student
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId {  get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string fullName { get; set; } // User input

        [Required]
        [MaxLength(150)]
        public string email { get; set; } // User input


       
        [MaxLength(20)]
        public string? phoneNumber { get; set; } // User input


        [Required]
        public DateTime dateOfBirth { get; set; } // Calculated

        [Required]
        [Range(2000,2030)]
        public int enrollmentYear { get; set; } // User input

        [Range(0.0, 4.0)]
        public decimal gpa { get; set; } = 0.0m;// Calculated




        //Relationships
        public ICollection<Enrollment> Enrollments { get; set; } // Navigation property 


        public ICollection<Course> Courses { get; set; } // Navigation property



    }
}
