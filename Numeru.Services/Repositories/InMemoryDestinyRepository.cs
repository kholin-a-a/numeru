using System.Collections.Generic;
using System.Linq;

namespace Numeru.Services
{
    public class InMemoryDestinyRepository : IDestinyRepository
    {
        private readonly IEnumerable<string> _destinies;

        public InMemoryDestinyRepository(IEnumerable<string> destinies)
        {
            this._destinies = destinies;
        }

        public IEnumerable<string> GetAll()
        {
            return this._destinies
                .Select(d => d)
                .ToArray();
        }
    }
}
