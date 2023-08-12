namespace Xo.Core.Cqrs.Abstractions;

public abstract class BaseLookupQueryResult : BaseQueryResult
{
    public string Description { get; init; } = string.Empty;
}
