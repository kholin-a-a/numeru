using Numeru.Numerologic;
using System;

namespace Numeru.Services
{
    public class DateTimeAlgorithm : AbstractEvaluationAlgorithm<DateTime>
    {
        public DateTimeAlgorithm(AbstractEvaluator evaluator, IEvaluationTracer tracer) : base(evaluator, tracer)
        { }

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
