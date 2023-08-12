namespace Xo.Core.Cqrs.Abstractions;

public abstract class EmptyBaseCommand
{
    public ICommandResult Result { get; init; } = new EmptyCommandResult();
}
