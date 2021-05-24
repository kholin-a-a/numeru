using System.Collections.Generic;

namespace Numeru.Services
{
    public class DateAlgorithm : IDateAlgorithm
    {
        public IEnumerable<string> Plan()
        {
            return new List<string>()
            {
                "Дата",
                "+",
                "Время"
            };
        }
    }
}
