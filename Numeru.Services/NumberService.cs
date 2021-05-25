using System;
using System.Linq;

namespace Numeru.Services
{
    public class NumberService : INumberService
    {
        private readonly IPredictionRepository _predictions;

        public NumberService(
            IPredictionRepository predictions
            )
        {
            this._predictions = predictions;
        }

        public string Predict(int num)
        {
            var predictions = this._predictions
                .GetAll()
                .ToArray();

            var rate = new Random().Next(1, predictions.Length / num);
            var index = rate * num;

            return predictions[index];
        }
    }
}
