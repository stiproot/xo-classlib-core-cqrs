namespace Xo.Core.Cqrs.Abstractions;

public class BaseCommandResult : ICommandResult
{
    public long Id { get; init; } = -1;
}
