using System;
using System.Collections.Generic;

namespace Numeru.Services
{
    public interface IDateAlgorithm
    {
        IEnumerable<string> Plan();

        IEnumerable<string> Trace(DateTime dateTime);
    }
}
