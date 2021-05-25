using System.Linq;

namespace Numeru.Numerologic
{
    public abstract class AbstractEvaluator
    {
        public Number Evaluate(Number number)
        {
            if (this.Done(number))
            {
                return number;
            }

            var sum = number
                    .ToString()
                    .ToSequence()
                    .Sum();

            return this.Evaluate(
                new Number(sum)
                );
        }

        protected abstract bool Done(Number number);
    }
}
