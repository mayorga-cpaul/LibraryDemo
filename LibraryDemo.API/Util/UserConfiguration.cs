using LibraryDemo.API.Interfaces;
using MongoDB.Bson;
using System.Security.Cryptography;
using System.Text;

namespace LibraryDemo.API.Util;

public class UserConfiguration : IUserConfiguration
{
    public string EncryptPassword(string password, string key)
    {
        // TODO
        return password;
    }

    public string DecryptPassword(string encriptedPassword, string key)
    {
        // TODO
        return encriptedPassword;
    }
}
