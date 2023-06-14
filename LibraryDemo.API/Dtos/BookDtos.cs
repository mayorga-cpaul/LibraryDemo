namespace LibraryDemo.API.Dtos;

public record CreateBook(string Title, string AuthorId, string Publisher, 
    int PublicationYear, string Genre, decimal Price, 
    int QuantityAvailable);

public record UpdateBook(string Title, string AuthorId, string Publisher,
    int PublicationYear, string Genre, decimal Price,
    int QuantityAvailable);

public record BookDto(string BookId, DateTime CreationDate, string Title, string AuthorId, string Publisher,
    int PublicationYear, string Genre, decimal Price,
    int QuantityAvailable);