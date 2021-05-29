using Microsoft.AspNetCore.Mvc;

namespace Numeru.Web
{
    public class Calculation: ViewComponent
    {
        public IViewComponentResult Invoke(CalculationViewModel model)
        {
            return View("~/Views/Components/Calculation/Calculation.cshtml", model);
        }
    }
}
