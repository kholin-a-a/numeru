using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Numeru.Web.Views.Components.ViewScript
{
    public class ViewScript: ViewComponent
    {
        private readonly IWebHostEnvironment _env;

        public ViewScript(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public async Task<IViewComponentResult> InvokeAsync(string from)
        {
            var content = await File.ReadAllTextAsync(
                Path.Combine(this._env.ContentRootPath, from)
                );

            return View("~/Views/Components/ViewScript/ViewScript.cshtml", content);
        }
    }
}
