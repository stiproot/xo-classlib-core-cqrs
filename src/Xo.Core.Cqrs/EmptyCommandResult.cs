namespace Xo.Core.Cqrs.Abstractions;

public class EmptyCommandResult : ICommandResult
{
    public long Id { get; init; }
}
