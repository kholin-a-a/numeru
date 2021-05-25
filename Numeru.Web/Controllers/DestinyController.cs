using Microsoft.AspNetCore.Mvc;

namespace Numeru.Web.Controllers
{
    public class DestinyController: Controller
    {
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
            vm.Number = 3;
            vm.Prediction = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer mattis risus velit, eget egestas ex elementum ut. Nam fringilla ultricies faucibus. Donec orci est, blandit ut consectetur non, suscipit ac neque. Nulla molestie odio malesuada ligula fermentum porta. Vivamus eros tortor, volutpat ac odio non, vulputate gravida velit. Proin varius nisl dui, at faucibus ante porttitor sed. Nam vitae libero in arcu viverra ullamcorper.";

            return View(vm);
        }
    }
}
