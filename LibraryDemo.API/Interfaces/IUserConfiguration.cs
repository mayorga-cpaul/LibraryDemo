namespace LibraryDemo.API.Interfaces;

public interface IUserConfiguration
{ 
    string EncryptPassword(string password, string key);
    string DecryptPassword(string encriptedPassword, string key);
}
