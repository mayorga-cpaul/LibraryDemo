using LibraryDemo.API.Entities;

namespace LibraryDemo.API.Interfaces;

public interface ITokenServices
{
    string CreateToken(User user);
}
