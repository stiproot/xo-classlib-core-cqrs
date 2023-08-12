namespace Xo.Core.Cqrs.Abstractions;

public abstract class BaseCommand
{
    public ICommandResult Result { get; init; } = new EmptyCommandResult();
}
