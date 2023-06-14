using LibraryDemo.Core.Atributtes;

namespace LibraryDemo.API.Entities;

[BsonCollection("customer")]
public class Customer : Document
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}
