using System;

namespace Numeru.Services
{
    public class DateTimeAlgorithm : EvaluationAlgorithm<DateTime>
    {
        public override string Abstraction()
        {
            return "Дата + Время";
        }

        protected override string ToNumber(DateTime value)
        {
            return value.ToString("ddMMyyyyHHmmss");
        }
    }
}
