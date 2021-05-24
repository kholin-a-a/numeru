using Numeru.Numerologic;
using System.Collections.Generic;

namespace Numeru.Services
{
    public abstract class EvaluationAlgorithm<T>: IEvaluationAlgorithm<T>
    {
        public IEnumerable<string> Trace(T value)
        {
            var number = new Number(
                this.ToNumber(value)
                );

            number.Evaluate();

            return number.Trace();
        }

        public int Execute(T value)
        {
            var number = new Number(
                this.ToNumber(value)
                );

            number.Evaluate();

            return number.AsInt();
        }

        public virtual string Abstraction()
        {
            return string.Empty;
        }

        protected abstract string ToNumber(T value);
    }
}
