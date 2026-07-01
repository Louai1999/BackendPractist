using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace university.universityModel
{
    [Index(nameof(departmentName), IsUnique = true)]

    public class Department
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int departmentId {  get; set; } // System generated

        [Required]
        [MaxLength(100)]
        public string departmentName { get; set; } // Ueser input

        [Required]
        [MaxLength(50)]
        public string? building {  get; set; } // User input

        [Required]
        [Range(0,double.MaxValue)]
        public decimal budget { get; set; } = 0m;// Calculated


        [ForeignKey(" Instructor")]
        public int headInstructorId { get; set; } // foren key





        //Relationships
        public Instructor Instructors { get; set; } // Navigation property 

        public ICollection<Instructor> instructors { get; set; } // Navigation property
        public ICollection<Course> Courses { get; set; } // Navigation property


    }
}
