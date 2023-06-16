namespace LibraryDemo.API.Dtos;

public record CreateAuthor(string name, string nationality, DateTime DateOfBirth);
public record UpdateAuthor(string Name, string Nationality);
public record AuthorDto(string id, string name, string nationality, DateTime DateOfBirth);