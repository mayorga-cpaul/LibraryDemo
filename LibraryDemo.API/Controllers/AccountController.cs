using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using LibraryDemo.API.Errors;
using LibraryDemo.API.Extensions;
using LibraryDemo.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDemo.API.Controllers;

public class AccountController : BaseControllerApi
{
    private readonly ITokenServices _tokenService;
    private readonly IUserConfiguration _userConfiguration;
    private readonly IMongoRepository<User> _userRepository;

    public AccountController(
        ITokenServices tokenService, IUserConfiguration userConfiguration, IMongoRepository<User> userRepository)
    {
        _tokenService = tokenService;
        _userConfiguration = userConfiguration;
        _userRepository = userRepository;
    }

    [HttpPost(nameof(Login))]
    public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
    {
        var user = await _userRepository.FindOneAsync(e => e.Email == loginDto.Email);

        if (user == null) return Unauthorized(new ApiResponse(401));

        var result = user.Password.Equals(_userConfiguration.DecryptPassword(user.Password, loginDto.Password));

        if (!result) return Unauthorized(new ApiResponse(401));

        return user.AsDto(_tokenService);
    }
    
    [HttpPost(nameof(Register))]
    public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
    {
        var existinUser = await _userRepository.FindOneAsync(e => e.Email == registerDto.Email);

        if (!(existinUser is null))
        {
            return new BadRequestObjectResult(new ApiValidationErrorResponse
            { Errors = new[] { "Email address is in use" } });
        }

        var user = new User
        {
            Password = _userConfiguration.EncryptPassword(registerDto.Password, registerDto.Password),
            DisplayName = registerDto.DisplayName,
            Email = registerDto.Email
        };

        await _userRepository.InsertOneAsync(user);
        return user.AsDto(_tokenService);
    }
}