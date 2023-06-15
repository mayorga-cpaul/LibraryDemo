namespace LIbraryDemo.Client.Interfaces;

public interface IGenericClientServices <TDocument, TCreate>
    where TDocument : IDocument where TCreate : ICreateDocument
{
    Task<IEnumerable<TDocument>> ListAsync();
    Task CreateAsync(TCreate created);
}
