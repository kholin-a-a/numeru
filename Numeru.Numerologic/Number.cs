using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeru.Numerologic
{
    public class Number
    {
        private string _number;

        public Number(string number)
        {
            this._number = number;
        }

        public void Evaluate()
        {
            while(!this.IsEvaluated())
            {
                var sum = this._number
                    .ToSequence()
                    .Sum();

                this._number = sum.ToString();
            }
        }

        public bool IsBase()
        {
            return this._number.ToSequence().Count() == 1;
        }

        public bool IsDominant()
        {
            var numbers = this._number.ToSequence();

            return numbers.Count() > 1
                &&
                numbers.All(n => n == numbers.First())
                ;
        }

        public bool IsKarmic()
        {
            var karmic = new List<int> { 13, 14, 16, 19 };

            return this._number.ToSequence().Count() == 2
                &&
                karmic.Contains(
                    this._number.ToNumber()
                );
        }

        public bool IsEvaluated()
        {
            return
                this.IsBase()
                ||
                this.IsDominant()
                ||
                this.IsKarmic();
        }

        public int AsInt()
        {
            if (!this.IsEvaluated())
                throw new InvalidOperationException("Unable to cast non-evaluated numbers");

            return this._number.ToNumber();
        }
    }
}
