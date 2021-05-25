using System;
using System.Collections.Generic;

namespace Numeru.Web
{
    public class MomentIndexViewModel
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string Prediction { get; set; }

        public IEnumerable<string> Calculation { get; set; }

        public IEnumerable<string> CalculationRemark { get; set; }
    }
}
