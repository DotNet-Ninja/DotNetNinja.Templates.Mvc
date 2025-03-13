using System.Text.Encodings.Web;
using DotNetNinja.Templates.Mvc.Constants;
using Humanizer;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetNinja.Templates.Mvc.TagHelpers;

[HtmlTargetElement("icon")]
public class IconTagHelper: TagHelper
{
    [HtmlAttributeName("value")]
    public BootstrapIcons Icon { get; set; } = BootstrapIcons.NotSet;

    [HtmlAttributeName("name")]
    public string IconClass { get; set; } = string.Empty;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var icon = (!string.IsNullOrWhiteSpace(IconClass)) ? IconClass : string.Empty;
        if (Icon != BootstrapIcons.NotSet)
        {
            icon = Icon.Humanize();
        }

        if (string.IsNullOrWhiteSpace(icon))
        {
            output.SuppressOutput();
        }
        else
        {
            var iconClass = $"bi-{icon}";
            output.TagName = "i";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.AddClass("bi", HtmlEncoder.Default);
            output.AddClass(iconClass, HtmlEncoder.Default);
        }

        base.Process(context, output);
    }
}