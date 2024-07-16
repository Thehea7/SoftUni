using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(80)")]
        public string Name { get; set; } = null!;

        public string?  Description { get; set; }

        [Required] 
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required] 
        public decimal Price { get; set; }

        public virtual ICollection<StudentCourse> StudentsCourses { get; set; } = null!;

        public virtual ICollection<Resource> Resources { get; set; } = null!;


        public virtual ICollection<Homework> Homeworks { get; set; } = null!; 
    }
}
