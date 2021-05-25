using System.Linq;

namespace Numeru.Numerologic
{
    public abstract class AbstractEvaluator
    {
        public Number Evaluate(Number number)
        {
            while(!this.Done(number))
            {
                var sum = number
                    .AsString()
                    .ToSequence()
                    .Sum();

                this.Evaluate(
                    new Number(sum)
                    );
            }

            return number;
        }

        protected abstract bool Done(Number number);
    }
}
