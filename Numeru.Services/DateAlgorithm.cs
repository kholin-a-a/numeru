using Numeru.Numerologic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeru.Services
{
    public class DateAlgorithm : IDateAlgorithm
    {
        public IEnumerable<string> Plan()
        {
            return new List<string>()
            {
                "Дата + Время"
            };
        }

        public IEnumerable<string> Trace(DateTime dateTime)
        {
            var number = new Number(
                dateTime.ToString("ddMMyyyyhhmmss")
                );

            number.Evaluate();

            return number
                .Trace()
                .Skip(2);
        }
    }
}
