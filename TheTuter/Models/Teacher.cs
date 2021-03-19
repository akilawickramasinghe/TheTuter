﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class Teacher:User
    {
        public string tId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
