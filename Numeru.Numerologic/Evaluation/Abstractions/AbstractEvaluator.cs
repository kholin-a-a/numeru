using System.Linq;

namespace Numeru.Numerologic
{
    public abstract class AbstractEvaluator
    {
        public Number Evaluate(Number number)
        {
            return this.Evaluate(
                number, new DefaultTracer()
                );
        }

        public Number Evaluate(Number number, IEvaluationTracer tracer)
        {
            if (this.Done(number))
            {
                tracer.Done(number);
                return number;
            }

            tracer.Taken(number);

            var sequence = number.ToString().ToSequence();
            tracer.Split(sequence);

            var sum = sequence.Sum();

            return this.Evaluate(
                new Number(sum), tracer
                );
        }

        protected abstract bool Done(Number number);
    }
}
