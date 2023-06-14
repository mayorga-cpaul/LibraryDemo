using LibraryDemo.Core.Atributtes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryDemo.API.Entities;

[BsonCollection("book")]
public class Book : Document
{
    public Book(string title, string authorId, string publisher, int publicationYear, string genre, decimal price, int quantityAvailable)
    {
        Title = title;
        AuthorId = authorId;
        Publisher = publisher;
        PublicationYear = publicationYear;
        Genre = genre;
        Price = price;
        QuantityAvailable = quantityAvailable;
    }

    public string Title { get; set; } = string.Empty;
    [BsonRepresentation(BsonType.ObjectId)]
    public string AuthorId { get; set; }
    public string Publisher { get; set; } = string.Empty;
    public int PublicationYear { get; set; }
    public string Genre { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int QuantityAvailable { get; set; }
}


