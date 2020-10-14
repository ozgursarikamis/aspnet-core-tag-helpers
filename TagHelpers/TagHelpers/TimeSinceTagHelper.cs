using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("time-since")]
    public class TimeSinceTagHelper: TagHelper
    {
        public string CompareDateTime { get; set; }
        public ITimeSinceService TimeSinceService { get; }

        public TimeSinceTagHelper(ITimeSinceService timeSinceService)
        {
            TimeSinceService = timeSinceService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent(TimeSinceService.TimeSince(Convert.ToDateTime(CompareDateTime)));
        }
    }
}
