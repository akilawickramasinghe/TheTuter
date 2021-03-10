using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class User : IdentityUser 
    { 
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool IsStudent { get; set; }
    }
}
