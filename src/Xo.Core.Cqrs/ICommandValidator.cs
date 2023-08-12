namespace Xo.Core.Cqrs.Abstractions;

public interface ICommandValidator<in TCommand>
    where TCommand : ICommand
{
    bool Validate(TCommand cmd);
}
