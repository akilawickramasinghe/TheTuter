using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.ViewModel
{
    public class ContactUsViewModel
    {
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
