using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class Student 
    {

        [Key]
        public int sId { get; set; }

        public ICollection<CourseStudent> Course { get; set; }
    }
}
