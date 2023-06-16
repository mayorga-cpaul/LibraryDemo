using LibraryDemo.Client.Models;

namespace LIbraryDemo.Client.Interfaces;

public interface IUserServices
{
    Task<User> AccessToAPI(Login login);
    Task<User> CreateUser(Register register);
}
