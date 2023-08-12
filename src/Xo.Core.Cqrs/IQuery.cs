namespace Xo.Core.Cqrs.Abstractions;

public interface IQuery : IBaseQuery
{
    long Id { get; init; }
}
