﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("auto-price")]
    public class AutoPriceTagHelper : TagHelper
    {
        [HtmlAttributeNotBound]
        public string Make { get; set; }

        [HtmlAttributeName("model-name")]
        public string Model { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
