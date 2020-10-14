using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("view-ctx")]
    public class ViewCtxTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string MiscString { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var isHttps = ViewContext.HttpContext.Request.IsHttps;
            output.Content.SetHtmlContent("<br />isHttps: " + isHttps);
        }
    }
}
