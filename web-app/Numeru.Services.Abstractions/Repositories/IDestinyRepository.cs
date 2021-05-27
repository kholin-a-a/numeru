using System.Collections.Generic;

namespace Numeru.Services
{
    public interface IDestinyRepository
    {
        IEnumerable<string> GetAll();
    }
}
