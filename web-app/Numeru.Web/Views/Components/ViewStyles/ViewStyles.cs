using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace Numeru.Web
{
    public class ViewStyles: ViewComponent
    {
        private readonly IWebHostEnvironment _env;

        public ViewStyles(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public async Task<IViewComponentResult> InvokeAsync(string from)
        {
            var content = await File.ReadAllTextAsync(
                Path.Combine(this._env.ContentRootPath, from)
                );
            
            return View("~/Views/Components/ViewStyles/ViewStyles.cshtml", content);
        }
    }
}
