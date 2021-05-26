using Numeru.Numerologic;
using System.Collections.Generic;
using System.Linq;

namespace Numeru.Services
{
    public class EvaluationTracer : IEvaluationTracer
    {
        private readonly List<string> _trace;

        public EvaluationTracer()
        {
            this._trace = new List<string>();
        }

        public void Clear()
        {
            this._trace.Clear();
        }

        public void Split(IEnumerable<int> sequence)
        {
            this._trace.Add("→");
            this._trace.Add(
                string.Join(" + ", sequence)
                );
        }

        public void Summed(Number number)
        {
            this._trace.Add("=");
            this._trace.Add(number.ToString());
        }

        public void Taken(Number number)
        {
            if (this._trace.Any())
                return;

            this._trace.Add(number.ToString());
        }

        public IEnumerable<string> Trace()
        {
            return this._trace;
        }
    }
}
