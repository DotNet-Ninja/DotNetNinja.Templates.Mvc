namespace DotNetNinja.Templates.Mvc.Services;

public class DefaultTimeProvider : ITimeProvider
{
    public DefaultTimeProvider()
    {
        RequestTime = DateTimeOffset.Now;
    }

    public DateTimeOffset Now => DateTimeOffset.Now;
    public DateTimeOffset RequestTime { get; }
}