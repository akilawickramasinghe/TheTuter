using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.Models
{
    public class PaymentInformation
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string TeacherId { get; set; }
        public string Subject { get; set; }
        public decimal Price { get; set; }
        public string CardNumber { get; set; }
        public int MonthExpiry { get; set; }
        public int YearExpiry { get; set; }
        public int Cvv { get; set; }
        public Boolean IsActive { get; set; }
    }
}
