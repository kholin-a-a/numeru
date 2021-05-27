using System.Collections.Generic;
using System.Linq;

namespace Numeru.Services
{
    public class InMemoryPredictionRepository : IPredictionRepository
    {
        private readonly IEnumerable<string> _predictions;

        public InMemoryPredictionRepository(IEnumerable<string> predictions)
        {
            this._predictions = predictions;
        }

        public IEnumerable<string> GetAll()
        {
            return this._predictions
                .Select(s => s)
                .ToList();
        }
    }
}
