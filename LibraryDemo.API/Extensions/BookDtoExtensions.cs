using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using MongoDB.Bson;

namespace LibraryDemo.API.Extensions;

public static class BookDtoExtensions
{
    public static Book AsEntity(this CreateBook createBook)
        => new Book(createBook.Title, createBook.AuthorId,
             createBook.Publisher, createBook.PublicationYear, createBook.Genre, 
             createBook.Price, createBook.QuantityAvailable);

    public static BookDto AsDto(this Book book)
         => new BookDto(book.Id.ToString(), book.CreatedAt, book.Title, book.AuthorId.ToString(),
             book.Publisher, book.PublicationYear, book.Genre, book.Price, book.QuantityAvailable);

    public static IEnumerable<BookDto> AsListDto(this IEnumerable<Book> books)
        => books.Select(e => e.AsDto());
}
