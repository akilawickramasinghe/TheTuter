using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<CourseStudent> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public Course()
        {

        }
    }
}
