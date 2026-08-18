using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace university.universityModel
{
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int courseId {  get; set; } // System generated

        [Required]
        [MaxLength(10)]
        public string courseCode { get; set; } // User input

        [Required]
        [MaxLength(150)]
        public string courseTitel {  get; set; } // User input

        [Required]
        [Range(1,6)]
        public int creditHours { get; set; } // Calculated

       // [ForeignKey(" Department")]
       // public int departmentId { get; set; } // Foreign key

       // [ForeignKey(" Instructor")]
      //  [Required]
       // public int instructorId { get; set; } // Foreign key

        [Required]
        [MaxLength(20)]
        public string semesterOffered { get; set; } // User input 


        //Relationships
        public ICollection<Student> Students { get; set; } // Navigation property 

        [ForeignKey("Department")]
        public int departmentId { get; set; } // Foreign key property 
        public Department departments { get; set; } // Navigation property 

        [ForeignKey("Instructor")]
        public int instructorId { get; set; } // Foreign key property 
        public Instructor instructors { get; set; } // Navigation property 

        [ForeignKey("Enrollment")]
        public int EnrollmentId { get; set; } // Foreign key property 
        public Enrollment enrollment { get; set; } // Navigation property

    }
}
