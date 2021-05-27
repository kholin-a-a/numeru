using System.Collections.Generic;

namespace Numeru.Numerologic
{
    internal class DefaultTracer : IEvaluationTracer
    {
        public void Clear()
        { }

        public void Split(IEnumerable<int> sequence)
        { }

        public void Summed(Number number)
        { }

        public void Taken(Number number)
        { }

        public IEnumerable<string> Trace()
        {
            return default;
        }
    }
}
