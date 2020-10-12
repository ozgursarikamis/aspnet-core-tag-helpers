using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("my-customer", Attributes = "info")]
    public class MyCustomerTagHelper : TagHelper
    {
        public string Info { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent("Current Time" + DateTime.Now.ToString("F"));
            output.TagName = "strong";

            var data = _nameList.FirstOrDefault(x => x.Name == Info);

            if (data == null) return;
            var result = $"Name: {data.Name} Address: {data.Address}";

            output.Content.SetContent(result);
        }

        private class NameRecord
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        private readonly List<NameRecord> _nameList = new List<NameRecord>
        {
            new NameRecord { Name = "Naomi", Address = "1600 Amphith" },
            new NameRecord { Name = "Igor", Address = "123 Somewhere St" },
        };
    }
}
