using LibraryDemo.API.Interfaces;
using MongoDB.Bson;

namespace LibraryDemo.API.Entities;

public class Document : IDocument
{
    public ObjectId Id { get; set; }
    public DateTime CreatedAt => Id.CreationTime;
}
