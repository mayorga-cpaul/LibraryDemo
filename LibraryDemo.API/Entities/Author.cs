using LibraryDemo.Core.Atributtes;

namespace LibraryDemo.API.Entities;

[BsonCollection("author")]
public class Author : Document
{
    public Author(string name, string nationality)
    {
        Name = name;
        Nationality = nationality;
    }

    public string Name { get; set; }
    public string Nationality { get; set; }
    public DateTime DateOfBirth { get; set; }
}