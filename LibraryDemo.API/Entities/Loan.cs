using LibraryDemo.Core.Atributtes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryDemo.API.Entities;

[BsonCollection("loan")]
public class Loan : Document
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string CustomerId { get; set; } = string.Empty;
    [BsonRepresentation(BsonType.ObjectId)]
    public string BookId { get; set; } = string.Empty;
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
}
