using System.Collections.Generic;
using System.Linq;

namespace Numeru.Numerologic
{
    internal static class StringExtensions
    {
        public static IEnumerable<int> ToSequence(this string number)
        {
            return number
                .Select(c => c.ToString())
                .Select(c => int.Parse(c))
                ;
        }

        public static int ToNumber(this string number)
        {
            return int.Parse(number);
        }
    }
}
