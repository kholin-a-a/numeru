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

            return View(vm);
        }
    }
}
