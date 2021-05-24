using Numeru.Numerologic;
using System;

namespace Numeru.Services
{
    public class NumberKindDefinder: IKindDefinder
    {
        public NumberKind Define(int num)
        {
            var number = new Number(num);

            if (!number.IsEvaluated())
                throw new InvalidOperationException("Unable to define the kind of not evaluated number");

            if (number.IsKarmic())
            {
                return NumberKind.Karmic;
            }
            else if (number.IsDominant())
            {
                return NumberKind.Dominant;
            }
            else
            {
                return NumberKind.Base;
            }
        }
    }
}
