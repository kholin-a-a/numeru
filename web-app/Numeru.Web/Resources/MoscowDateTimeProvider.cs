using System;

namespace Numeru.Web
{
    public class MoscowDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now()
        {
            return DateTime.UtcNow.AddHours(3);
        }
    }
}
