using Microsoft.AspNetCore.Mvc;
using Numeru.Services;

namespace Numeru.Web.Controllers
{
    public class DestinyController: Controller
    {
        private readonly IEvaluationAlgorithm<Person> _algorithm;
        private readonly INumberService _number;

        public DestinyController(
            IEvaluationAlgorithm<Person> algorithm,
            INumberService number
        )
        {
            this._algorithm = algorithm;
            this._number = number;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(
                new DestinyIndexViewModel()
                );
        }

        [HttpPost]
        public ActionResult Index(DestinyIndexViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                vm.Calculated = false;
                return View(vm);
            }

            vm.Calculated = true;

            var person = new Person
            {
                Fullname = vm.Fullname,
                BirthDate = vm.BirthDate
            };

            vm.Number = this._algorithm.Execute(person);
            vm.Prediction = this._number.Destiny(vm.Number);
            vm.Calculation = new CalculationViewModel
            {
                Calculations = this._algorithm.Trace(person),
                Abstract = this._algorithm.Abstraction()
            };

            return View(vm);
        }
    }
}
