using Numeru.Numerologic;
using System.Collections.Generic;

namespace Numeru.Services
{
    public abstract class EvaluationAlgorithm<T>: IEvaluationAlgorithm<T>
    {
        private readonly AbstractEvaluator _evaluator;

        public EvaluationAlgorithm(AbstractEvaluator evaluator)
        {
            this._evaluator = evaluator;
        }

        public IEnumerable<string> Trace(T value)
        {
            // TO DO: Implement
            return new List<string>();
        }

        public int Execute(T value)
        {
            var number = new Number(
                this.ToNumber(value)
                );

            return this._evaluator
                .Evaluate(number)
                .AsInt();
        }

        public virtual string Abstraction()
        {
            return string.Empty;
        }

        protected abstract string ToNumber(T value);
    }
}
