using DotNetNinja.Templates.Mvc.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetNinja.Templates.Mvc.TagHelpers;

[HtmlTargetElement("copyright", TagStructure = TagStructure.WithoutEndTag)]
public class CopyrightTagHelper: TagHelper
{
    private readonly ITimeProvider _time;

    public CopyrightTagHelper(ITimeProvider time)
    {
        _time = time;
    }

    public int StartYear { get; set; }

    public string Message { get; set; } = "DotNetNinja.Templates.Mvc";

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var currentYear = _time.Now.Year;
        var firstYear = (StartYear < 1800) ? currentYear : StartYear;
        var years = (StartYear < currentYear) ? $"{StartYear}-{currentYear}" : currentYear.ToString();
        output.TagName = null;
        output.Content.SetHtmlContent($"&copy; Copyright {years} {Message}");
        base.Process(context, output);
    }
}