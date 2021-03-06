﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "[make ^= 't']")]
    [HtmlTargetElement(Attributes = "[make ^= 'f'],[model $= 'er']")]
    public class AutoPriceTagHelper : TagHelper
    { 
        public string Make { get; set; }

        public string Model { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
