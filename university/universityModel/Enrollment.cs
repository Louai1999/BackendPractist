using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace university.universityModel
{
    public class Enrollment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId {  get; set; } // System generated

        

        [ForeignKey(" Course")]
        [Required]
        public int courseId { get; set; } // Foreign key

        [Required]
        public DateTime enrollmentDate { get; set; } // User input

        [MaxLength(2)]
        public string? finalGrade { get; set; } // Calculated 

        [Required]
        [MaxLength(20)]
        public string status { get; set; } = "In Progress"; // From list  in progress | completed | Deleted




        //Relationships
        [ForeignKey("Student")]
        [Required]
        public int studentId { get; set; } // Foreign key property
        public Student student { get; set; } // navigation property

        public ICollection<Course> Courses { get; set; } // Navigation property


    }
}
