using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System;
using System.Collections.Generic;
using System.Linq;

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
                Description = this._number.Describe(number),
                Date = date,
                Prediction = this._number.Predict(number),
                Calculation = this._algorithm
                    .Trace(date)
                    .Skip(2),
                CalculationRemark = new List<string>()
                {
                    this._algorithm.Abstraction()
                }
            };

            return View(vm);
        }
    }
}
