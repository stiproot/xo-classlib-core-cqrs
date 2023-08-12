namespace Xo.Core.Cqrs.Abstractions;

public interface IEnricher<T>
{
    void Enrich(T unenriched);
}
