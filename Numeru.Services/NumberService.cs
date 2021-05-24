using Numeru.Numerologic;
using System;

namespace Numeru.Services
{
    public class NumberService : INumberService
    {
        public int FromDate(DateTime dateTime)
        {
            var number = new Number(
                dateTime.ToString("ddMMyyyyhhmmss")
                );

            number.Evaluate();

            return number.AsInt();
        }
    }
}
