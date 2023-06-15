
using LIbraryDemo.Client;
using LIbraryDemo.Client.Helpers;
using LIbraryDemo.Client.Interfaces;
using LIbraryDemo.Client.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        // register services for DI
        services.AddSingleton<JsonSerializerOptionsWrapper>();

        services.AddScoped(typeof(IGenericClientServices<>), typeof(GenericClientServices<>));
        services.AddScoped<Login>();
        services.AddScoped<AuthorView>();

        services.AddHttpClient("LibraryAPIClientDemo", configureClient =>
        {
            configureClient.BaseAddress = new Uri("http://localhost:7273");
            configureClient.Timeout = new TimeSpan(0, 0, 30);
        }); 
    }).Build();

try
{
    var logger = host.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Host created.");

    host.Services.GetRequiredService<Login>().ShowDialog();
}
catch (Exception generalException)
{
    // log the exception
    var logger = host.Services.GetRequiredService<ILogger<Program>>();
    logger.LogError(generalException,
        "An exception happened while running the program");
}