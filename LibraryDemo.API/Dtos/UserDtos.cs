namespace LibraryDemo.API.Dtos;

public record UserDto(string Email, string DisplayName, string Token);
public record LoginDto(string Email, string Password);
public record RegisterDto(string Email, string Password, string DisplayName);