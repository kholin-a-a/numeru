using System.Collections.Generic;

namespace Numeru.Numerologic
{
    internal class DefaultTracer : IEvaluationTracer
    {
        public void Done(Number number)
        { }

        public void Split(IEnumerable<int> sequence)
        { }

        public void Summed(Number number)
        { }

        public void Taken(Number number)
        { }
    }
}
