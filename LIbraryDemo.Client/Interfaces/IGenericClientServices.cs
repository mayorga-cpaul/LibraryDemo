using LibraryDemo.Client.Models;

namespace LIbraryDemo.Client.Interfaces;

public interface IGenericClientServices <TDocument, TCreate>
    where TDocument : IDocument where TCreate : ICreateDocument
{
    Task<List<TDocument>> ListAsync();
    Task CreateAsync(TCreate created);
    Task DeleteAsync(string documentId);
    Task<TDocument> UpdateAsync(TCreate author, string authorId);
}
