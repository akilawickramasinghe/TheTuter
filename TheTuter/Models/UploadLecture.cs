using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class UploadLecture
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Batch { get; set; }
        public string Class { get; set; }
        public string Lesson { get; set; }
        public string Path { get; set; }
    }
}
