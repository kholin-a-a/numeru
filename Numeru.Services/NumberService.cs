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

        public string Destiny(int num)
        {
            return "";
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
