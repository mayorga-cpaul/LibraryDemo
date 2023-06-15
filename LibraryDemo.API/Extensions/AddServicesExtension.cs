using LibraryDemo.API.Data;
using LibraryDemo.API.Errors;
using LibraryDemo.API.Interfaces;
using LibraryDemo.API.Services;
using LibraryDemo.API.Settings.DbConnection;
using LibraryDemo.API.Util;
using LibraryDemo.Infraestructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using System.Text;

namespace LibraryDemo.API.Extensions;

public static class AddServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<MongoDbSettings>(configuration.GetSection(nameof(MongoDbSettings)));

        services.AddSingleton<IMongoDbSettings>(serviceProvider =>
            serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

        var mongoDbSettings = configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();

        services.AddSingleton<IMongoClient>(serviceProvider =>
        {
            return new MongoClient(mongoDbSettings?.ConnectionString);
        });

        services.AddScoped<IBookServices, BookServices>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ITokenServices, TokenService>();

        services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
        services.AddSingleton<IUserConfiguration, UserConfiguration>();

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.InvalidModelStateResponseFactory = actionContext =>
            {
                var errors = actionContext.ModelState
                    .Where(e => e.Value!.Errors.Count > 0)
                    .SelectMany(x => x.Value!.Errors)
                    .Select(x => x.ErrorMessage).ToArray();

                var errorResponse = new ApiValidationErrorResponse
                {
                    Errors = errors
                };

                return new BadRequestObjectResult(errorResponse);
            };
        });


        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"]!)),
                    ValidIssuer = configuration["Token:Issuer"]!,
                    ValidateIssuer = true,
                    ValidateAudience = false
                };
            });
        return services;
    }
}