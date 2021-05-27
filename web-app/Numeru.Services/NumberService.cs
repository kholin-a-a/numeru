using System;
using System.Linq;

namespace Numeru.Services
{
    public class NumberService : INumberService
    {
        private readonly IPredictionRepository _predictions;
        private readonly IDestinyRepository _destinies;

        public NumberService(
            IPredictionRepository predictions,
            IDestinyRepository destinies
            )
        {
            this._predictions = predictions;
            this._destinies = destinies;
        }

        public string Destiny(int num)
        {
            return this._destinies
                .GetAll()
                .ElementAt(num - 1);
        }

        public string Predict(int num)
        {
            var predictions = this._predictions
                .GetAll()
                .ToArray();

            var seed = (int)DateTime.Now.TimeOfDay.TotalSeconds;
            var rate = new Random(seed).Next(1, predictions.Length / num);
            var index = rate * num;

            return predictions[index];
        }


    }
}
