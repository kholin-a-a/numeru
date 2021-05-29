using Microsoft.AspNetCore.Mvc;

namespace Numeru.Web
{
    public class OpenGraph: ViewComponent
    {
        public IViewComponentResult Invoke(string title, string description)
        {
            var vm = new OpenGraphViewModel
            {
                Title = title,
                Description = description
            };

            return View("~/Views/Components/OpenGraph/OpenGraph.cshtml", vm);
        }
    }
}
