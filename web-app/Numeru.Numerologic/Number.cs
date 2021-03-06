using System.Collections.Generic;
using System.Linq;

namespace Numeru.Numerologic
{
    public class Number
    {
        private string _strForm;

        public Number(string number)
        {
            this._strForm = number;
        }

        public Number(int number)
        {
            this._strForm = number.ToString();
        }

        public bool IsBase()
        {
            return this._strForm.ToSequence().Count() == 1;
        }

        public bool IsDominant()
        {
            var numbers = this._strForm.ToSequence();

            return numbers.Count() > 1
                &&
                numbers.All(n => n == numbers.First())
                ;
        }

        public bool IsKarmic()
        {
            var karmic = new List<int> { 13, 14, 16, 19 };

            return this._strForm.ToSequence().Count() == 2
                &&
                karmic.Contains(
                    this._strForm.ParseInt()
                );
        }

        public int ToInt()
        {
            return this._strForm.ParseInt();
        }

        public override string ToString()
        {
            return this._strForm;
        }
    }
}
