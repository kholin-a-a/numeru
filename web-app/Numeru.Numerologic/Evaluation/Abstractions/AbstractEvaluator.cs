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
                return number;
            }

            tracer.Taken(number);

            var sequence = number.ToString().ToSequence();
            tracer.Split(sequence);

            var sum = new Number(sequence.Sum());
            tracer.Summed(sum);

            return this.Evaluate(sum, tracer);
        }

        protected abstract bool Done(Number number);
    }
}
