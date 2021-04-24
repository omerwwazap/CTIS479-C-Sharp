using LeventDurdali_HW2.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace LeventDurdali_HW2.Infrastructure
{
    public class CustomNameTagHelper : TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustumTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            //name=In this project you will see:
            sb.AppendFormat("<span>This is an Tag Helper.<br> {0}  <br>{1} and  {2}</span>", this.Name, "Drones", "Helicopters");

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
