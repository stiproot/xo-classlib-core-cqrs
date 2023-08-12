namespace Xo.Core.Cqrs.Abstractions;

public interface IPagedQueryManager<TQuery, TQueryResult>
  where TQuery : IQuery
  where TQueryResult : IQueryResult
{
    void Validate();

    Task<IEnumerable<TQueryResult>> ManageAsync(
      TQuery qry,
      CancellationToken cancellationToken
    );
}

