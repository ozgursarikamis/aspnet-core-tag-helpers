using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [RestrictChildren("tab-item")]
    public class TabItemTagHelper : TagHelper
    {
        public string Title { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "li";
            var str = $"<a class='nav-link' href='#'>{Title}</a>";
            output.Content.SetHtmlContent(str);
        }
    }
}