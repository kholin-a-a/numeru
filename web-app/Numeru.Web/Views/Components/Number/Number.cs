using Microsoft.AspNetCore.Mvc;

namespace Numeru.Web
{
    public class Number: ViewComponent
    {
        public IViewComponentResult Invoke(int number)
        {
            return View("~/Views/Components/Number/Number.cshtml", number);
        }
    }
}
