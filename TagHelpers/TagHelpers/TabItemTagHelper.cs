using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [RestrictChildren("tab-item")]
    [HtmlTargetElement("tab-item", ParentTag = "tab")]
    public class TabItemTagHelper : TagHelper
    {
        public string Title { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var activePage = context.Items["ActivePage"] as string;
            //if (activePage == Title)
            //{
            //    // output.Attributes.Add("class", "active");
            //}
            var activeTabIndicator = activePage == Title ? "active" : "";
            output.TagName = "li";
            var str = $"<a class='{activeTabIndicator} nav-link' href='#'>{Title}</a>";
            output.Content.SetHtmlContent(str);
        }
    }
}