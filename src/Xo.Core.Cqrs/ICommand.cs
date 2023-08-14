namespace Xo.Core.Cqrs.Abstractions;

public interface ICommand
{
    ICommandResult Result { get; set; }
}
