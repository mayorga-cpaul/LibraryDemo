using LibraryDemo.API.Dtos;
using LibraryDemo.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDemo.API.Entities;

public class User : Document
{
    public string Email { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}