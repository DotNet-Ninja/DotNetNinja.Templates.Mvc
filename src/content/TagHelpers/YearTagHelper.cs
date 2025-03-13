using DotNetNinja.Templates.Mvc.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetNinja.Templates.Mvc.TagHelpers;

[HtmlTargetElement("year")]
public class YearTagHelper: TagHelper
{
    private readonly ITimeProvider _time;

    public YearTagHelper(ITimeProvider time)
    {
        _time = time;
    }

    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = null;
        output.Content.Clear();
        output.Content.SetHtmlContent(_time.RequestTime.Year.ToString());
        return base.ProcessAsync(context, output);
    }
}