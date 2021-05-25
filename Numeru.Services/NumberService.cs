﻿using System;
using System.Linq;

namespace Numeru.Services
{
    public class NumberService : INumberService
    {
        private readonly IDescriptionRepository _descriptions;
        private readonly IKindDefinder _kindDefinder;
        private readonly IPredictionRepository _predictions;

        public NumberService(
            IDescriptionRepository descriptions,
            IKindDefinder kindDefinder,
            IPredictionRepository predictions
            )
        {
            this._descriptions = descriptions;
            this._kindDefinder = kindDefinder;
            this._predictions = predictions;
        }

        public string Describe(int num)
        {
            return this._descriptions.Get(
                this._kindDefinder.Define(num)
                );
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
