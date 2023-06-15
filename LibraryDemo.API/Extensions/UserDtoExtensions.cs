using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using LibraryDemo.API.Interfaces;

namespace LibraryDemo.API.Extensions;

public static class UserDtoExtensions
{
    public static UserDto AsDto(this User user, ITokenServices tokenServices)
        => new UserDto(user.Email, user.DisplayName, tokenServices.CreateToken(user));
}
