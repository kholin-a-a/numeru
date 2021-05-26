using System.Collections.Generic;

namespace Numeru.Numerologic
{
    public interface IEvaluationTracer
    {
        void Taken(Number number);

        void Split(IEnumerable<int> sequence);

        void Summed(Number number);

        void Clear();

        IEnumerable<string> Trace();
    }
}
