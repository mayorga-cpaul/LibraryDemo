using LibraryDemo.API.Entities;

namespace LibraryDemo.API.Interfaces;

public interface IBookServices
{
    Task<List<Book>> ListBookAsync();
    Task UpdateBookAsync(Book book);
    Task CreateBookAsync(Book book);
    Task DeleteBookAsync(string bookId);
    Task<bool> ExistingAuthor(string authorId);
    Task<Book> GetBookByIdAsync(string bookId);
}
