using Numeru.Numerologic;
using System.Collections.Generic;

namespace Numeru.Services
{
    public abstract class AbstractEvaluationAlgorithm<T>: IEvaluationAlgorithm<T>
    {
        private readonly AbstractEvaluator _evaluator;
        private readonly IEvaluationTracer _tracer;

        public AbstractEvaluationAlgorithm(AbstractEvaluator evaluator, IEvaluationTracer tracer)
        {
            this._evaluator = evaluator;
            this._tracer = tracer;
        }

        public IEnumerable<string> Trace(T value)
        {
            var number = this.ToNumber(value);
            this._tracer.Clear();

            this._evaluator.Evaluate(number, this._tracer);

            return this._tracer.Trace();
        }

        public int Execute(T value)
        {
            var number = this.ToNumber(value);

            return this._evaluator
                .Evaluate(number)
                .ToInt();
        }

        public virtual string Abstraction()
        {
            return string.Empty;
        }

        protected abstract Number ToNumber(T value);
    }
}
