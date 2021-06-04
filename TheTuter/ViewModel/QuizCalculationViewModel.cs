using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTuter.ViewModel
{
    public class QuizCalculationViewModel
    {
        public int Total { get; set; }
        public int Answer { get; set; }
        public IList<GetQuizesViewModel> QuizesList { get; set; }
    }
}
