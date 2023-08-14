namespace Xo.Core.Cqrs.Abstractions;

public interface IPagedRows<TRow> : IPageable
    where TRow : IQueryResult
{
    IEnumerable<TRow> Rows { get; set; }
}
