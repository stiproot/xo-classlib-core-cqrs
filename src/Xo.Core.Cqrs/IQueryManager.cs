namespace Xo.Core.Cqrs.Abstractions;

public interface IQueryManager<TQuery, TQueryResult>
    where TQuery : IQuery
    where TQueryResult : IQueryResult
{
    void Validate();

    Task<TQueryResult> ManageAsync(
        TQuery qry,
        CancellationToken cancellationToken
    );
}

