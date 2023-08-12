namespace Xo.Core.Cqrs.Abstractions;

public interface IPageable
{
    uint TotalRowCount { get; init; }
    uint TotalPageCount { get; init; }
    uint PageSize { get; init; }
    uint PageNumber { get; init; }
}
