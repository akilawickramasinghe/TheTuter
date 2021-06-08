using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.DTO
{
    public class EmailDetailsDTO
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool UseSsl { get; set; }
        public bool RequiresAuthentication { get; set; }
        public string PreferredEncoding { get; set; } = string.Empty;
    }
}
