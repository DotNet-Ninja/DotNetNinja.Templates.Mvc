namespace DotNetNinja.Templates.Mvc.Services;

public class SystemTimeProvider : ITimeProvider
{
    public DateTimeOffset Now => DateTimeOffset.Now;
    public DateTimeOffset RequestTime { get; } = DateTimeOffset.Now;
}