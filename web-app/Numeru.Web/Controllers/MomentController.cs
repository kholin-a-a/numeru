using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System;

namespace Numeru.Web.Controllers
{
    public class MomentController: Controller
    {
        private readonly INumberService _number;
        private readonly IEvaluationAlgorithm<DateTime> _algorithm;
        private readonly IDateTimeProvider _dateTime;

        public MomentController(
            INumberService numberService,
            IEvaluationAlgorithm<DateTime> algorithm,
            IDateTimeProvider dateTime
        )
        {
            this._number = numberService;
            this._algorithm = algorithm;
            this._dateTime = dateTime;
        }

        public ActionResult Index()
        {
            var date = this._dateTime.Now();

            var number = this._algorithm.Execute(date);

            var vm = new MomentViewModel
            {
                Number = number,
                Date = date,
                Prediction = this._number.Predict(number),
                Calculation = new CalculationViewModel
                {
                    Abstract = this._algorithm.Abstraction(),
                    Calculations = this._algorithm.Trace(date)
                }
            };

            return View(vm);
        }
    }
}
