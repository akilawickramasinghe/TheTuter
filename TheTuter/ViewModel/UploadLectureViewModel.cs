using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.ViewModel
{
    public class UploadLectureViewModel
    {
        public string UserId { get; set; }
        public string Batch { get; set; }
        public string Class { get; set; }
        public string Lesson { get; set; }
        public string Path { get; set; }
        public IFormFile File { get; set; }
    }
}
