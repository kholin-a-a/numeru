using System.Collections.Generic;

namespace Numeru.Services
{
    public class RussianAlphabet : IAlphabet
    {
        private readonly List<string> _letters;

        public RussianAlphabet()
        {
            this._letters = new List<string>()
            {
                "а","б","в","г","д","е","ё","ж","з",
                "и","й","к","л","м","н","о","п","р",
                "с","т","у","ф","х","ц","ч","ш","щ",
                "ъ","ы","ь","э","ю","я"
            };
        }

        public bool Contains(string letter)
        {
            return this._letters.Contains(letter.ToLower());
        }

        public int NumberOf(string letter)
        {
            return this._letters.IndexOf(letter.ToLower()) + 1;
        }
    }
}
