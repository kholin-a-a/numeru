using Numeru.Numerologic;
using System;

namespace Numeru.Services
{
    public class NumberService : INumberService
    {
        private readonly IDescriptionRepository _descriptions;
        private readonly IKindDefinder _kindDefinder;

        public NumberService(
            IDescriptionRepository descriptions,
            IKindDefinder kindDefinder
            )
        {
            this._descriptions = descriptions;
            this._kindDefinder = kindDefinder;
        }

        public int FromDate(DateTime dateTime)
        {
            var number = new Number(
                dateTime.ToString("ddMMyyyyhhmmss")
                );

            number.Evaluate();

            return number.AsInt();
        }

        public string Describe(int num)
        {
            return this._descriptions.Get(
                this._kindDefinder.Define(num)
                );
        }
    }
}
