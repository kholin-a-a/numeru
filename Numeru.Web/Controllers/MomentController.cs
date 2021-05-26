using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System;

namespace Numeru.Web.Controllers
{
    public class MomentController: Controller
    {
        private readonly INumberService _number;
        private readonly IEvaluationAlgorithm<DateTime> _algorithm;

        public MomentController(
            INumberService numberService,
            IEvaluationAlgorithm<DateTime> algorithm
        )
        {
            this._number = numberService;
            this._algorithm = algorithm;
        }

        public ActionResult Index()
        {
            var date = DateTime.Now;

            var number = this._algorithm.Execute(date);

            var vm = new MomentIndexViewModel
            {
                Number = number,
                Date = date,
                Prediction = this._number.Predict(number),
                Calculation = new NumericCalculationViewModel
                {
                    Abstract = this._algorithm.Abstraction(),
                    Calculations = this._algorithm.Trace(date)
                }
            };

            return View(vm);
        }
    }
}
