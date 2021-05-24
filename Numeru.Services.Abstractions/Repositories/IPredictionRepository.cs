using System.Collections.Generic;

namespace Numeru.Services
{
    public interface IPredictionRepository
    {
        IEnumerable<string> GetAll();
    }
}
