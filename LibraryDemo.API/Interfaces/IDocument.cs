using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace LibraryDemo.API.Interfaces;

public interface IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    ObjectId Id { get; set; } 
    DateTime CreatedAt { get; }
}
