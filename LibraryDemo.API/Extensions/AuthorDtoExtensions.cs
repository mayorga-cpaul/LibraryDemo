using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;

namespace LibraryDemo.API.Extensions;

public static class AuthorDtoExtensions
{
    public static Author AsEntity(this CreateAuthor authorDto)
        => new Author(authorDto.name, authorDto.nationality) { DateOfBirth = authorDto.DateOfBirth };

    public static AuthorDto AsDto(this Author author)
         => new AuthorDto(author.Id.ToString(), author.Name, author.Nationality, author.DateOfBirth);

    public static IEnumerable<AuthorDto> AsListDto(this IEnumerable<Author> authors)
        => authors.Select(e => e.AsDto());
}