using System.Security.Claims;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetNinja.Templates.Mvc.TagHelpers;

[HtmlTargetElement("username")]
public class UserNameTagHelper : TagHelper
{

    public UserNameTagHelper(IHttpContextAccessor context)
    {
        _principal = context.HttpContext?.User ?? new ClaimsPrincipal();
    }

    private readonly ClaimsPrincipal _principal;

    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var name = _principal.Identity?.IsAuthenticated ?? false
            ? _principal.Identity.Name ?? string.Empty
            : string.Empty;
        output.TagName = null;
        output.Content.Clear();
        output.Content.SetHtmlContent(name);
        return base.ProcessAsync(context, output);
    }
}