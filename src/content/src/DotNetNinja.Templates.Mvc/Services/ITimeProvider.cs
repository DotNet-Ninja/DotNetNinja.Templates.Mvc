namespace DotNetNinja.Templates.Mvc.Services;

public interface ITimeProvider
{
    DateTimeOffset Now { get; }
    DateTimeOffset RequestTime { get; }
}