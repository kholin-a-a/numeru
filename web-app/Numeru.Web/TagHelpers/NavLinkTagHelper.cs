using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace Numeru.Web
{
    [HtmlTargetElement("a")]
    public class NavLinkTagHelper: TagHelper
    {
        public string RouteName { get; set; }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrEmpty(this.RouteName))
                return;

            if (this.RouteName.Equals(this.ViewContext.ViewData["Route"]))
            {
                output.AddClass("active", HtmlEncoder.Default);
            }
        }
    }
}
