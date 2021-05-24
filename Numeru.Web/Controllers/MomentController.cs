using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Numeru.Web.Controllers
{
    public class MomentController: Controller
    {
        private readonly INumberService _number;
        private readonly IDateAlgorithm _dateAlgorithm;

        public MomentController(
            INumberService numberService,
            IDateAlgorithm dateAlgorithm)
        {
            this._number = numberService;
            this._dateAlgorithm = dateAlgorithm;
        }

        public async Task<ActionResult> Index()
        {
            await Task.Yield();

            var date = DateTime.Now;
            var number = this._number.FromDate(date);

            var vm = new MomentIndexViewModel
            {
                Number = number,
                Description = this._number.Describe(number),
                Date = date,
                Prediction = "Если проявите внимательность, то разглядите большую любовь совсем близко от себя.",
                Calculation = this._dateAlgorithm.Trace(date),
                CalculationRemark = this._dateAlgorithm.Plan()
            };

            return View(vm);
        }
    }
}
