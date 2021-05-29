using System;

namespace Numeru.Web
{
    public class MomentIndexViewModel
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string Prediction { get; set; }

        public CalculationViewModel Calculation { get; set; }
    }
}
