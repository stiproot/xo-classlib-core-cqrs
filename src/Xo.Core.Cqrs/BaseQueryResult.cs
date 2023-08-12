namespace Xo.Core.Cqrs.Abstractions;

public abstract class BaseQueryResult
{
    public long Id { get; init; } = -1;
    public Guid Guid { get; init; } = Guid.Empty;
    public long UserId { get; init; } = -1;
    public DateTime CreationTimestampUtc { get; init; } = DateTime.UtcNow;
}
