using System;

namespace Numeru.Services
{
    public class NumberDescriptionRepository : IDescriptionRepository
    {
        public string Get(NumberKind kind)
        {
            switch(kind)
            {
                case NumberKind.Base:
                    return "Базовое число";
                case NumberKind.Dominant:
                    return "Господствующее число - благоприятный знак";
                case NumberKind.Karmic:
                    return "Кармическое число - благоприятный знак";
                default:
                    throw new Exception("Unexpected kind");
            }
        }
    }
}
