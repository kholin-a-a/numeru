using Microsoft.AspNetCore.Mvc;
using Numeru.Services;
using System.Linq;

namespace Numeru.Web.Controllers
{
    public class DestinyController: Controller
    {
        private readonly IEvaluationAlgorithm<Person> _algorithm;

        public DestinyController(
            IEvaluationAlgorithm<Person> algorithm
        )
        {
            this._algorithm = algorithm;
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
            vm.Prediction = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer mattis risus velit, eget egestas ex elementum ut. Nam fringilla ultricies faucibus. Donec orci est, blandit ut consectetur non, suscipit ac neque. Nulla molestie odio malesuada ligula fermentum porta. Vivamus eros tortor, volutpat ac odio non, vulputate gravida velit. Proin varius nisl dui, at faucibus ante porttitor sed. Nam vitae libero in arcu viverra ullamcorper.";
            vm.Calculation = new NumericCalculationViewModel
            {
                Calculations = this._algorithm.Trace(person),
                Abstract = this._algorithm.Abstraction()
            };

            return View(vm);
        }
    }
}
