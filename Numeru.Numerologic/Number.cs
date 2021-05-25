using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeru.Numerologic
{
    public class Number
    {
        private string _number;
        private readonly List<string> _trace;

        public Number(string number)
        {
            this._number = number;
            this._trace = new List<string>();
        }

        public Number(int num)
        {
            this._number = num.ToString();
        }

        public void Evaluate()
        {
            this._trace.Clear();
            this._trace.Add(this._number);

            while (!this.IsEvaluated())
            {    
                this._trace.Add("→");

                var seq = this._number.ToSequence();
                
                this._trace.Add(
                    string.Join(" + ", seq)
                    );

                var sum = seq.Sum();

                this._trace.Add("=");
                this._trace.Add(sum.ToString());

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

        public string AsString()
        {
            return this._number;
        }

        public IEnumerable<string> Trace()
        {
            return this._trace;
        }
    }
}
