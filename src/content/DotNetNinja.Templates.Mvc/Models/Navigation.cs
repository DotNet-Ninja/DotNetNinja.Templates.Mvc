using DotNetNinja.AutoBoundConfiguration;

namespace DotNetNinja.Templates.Mvc.Models;

[AutoBind("Navigation")]
public class Navigation
{
    public List<NavigationItem> Items { get; set; } = new();
}