namespace Xo.Core.Cqrs.Abstractions;

public abstract class BaseUpdateCommand : BaseCommand
{
    public long Id { get; init; }
}
