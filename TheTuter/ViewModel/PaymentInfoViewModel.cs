using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.ViewModel
{
    public class PaymentInfoViewModel
    {
        public string StudentId { get; set; }
        public string TeacherId { get; set; }
        public string Subject { get; set; }
        public decimal Price { get; set; }
        public string CardNumber { get; set; }
        public string MonthExpiry { get; set; }
        public string YearExpiry { get; set; }
        public string Cvv { get; set; }
    }
}
