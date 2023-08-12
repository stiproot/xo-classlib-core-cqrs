namespace Xo.Core.Cqrs.Abstractions;

public interface ICommandManager<in TCommand>
  where TCommand : ICommand
{
    void Validate();

    Task ManageAsync(
      TCommand cmd,
      CancellationToken cancellationToken
    );
}
