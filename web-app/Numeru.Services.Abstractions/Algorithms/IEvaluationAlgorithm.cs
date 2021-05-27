using System.Collections.Generic;

namespace Numeru.Services
{
    public interface IEvaluationAlgorithm<T>
    {
        IEnumerable<string> Trace(T value);

        int Execute(T value);

        string Abstraction();
    }
}
