using System.Collections.Generic;

namespace Numeru.Services
{
    public class RussianAlphabet : IAlphabet<Russian>
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

        public int NumberOf(string letter)
        {
            return this._letters.IndexOf(letter) + 1;
        }
    }
}
