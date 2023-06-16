
using LibraryDemo.Client.Models;
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

        services.AddScoped(typeof(IGenericClientServices<,>), typeof(GenericClientServices<,>));
        services.AddScoped<IUserServices, UserServices>();
        
        services.AddScoped<AuthorView>();
        services.AddScoped<LoginView>();

        services.AddHttpClient("LibraryAPIClientDemo", configureClient =>
        {
            configureClient.BaseAddress = new Uri("https://localhost:7273");
            configureClient.Timeout = new TimeSpan(0, 0, 30);
        });

        using (var serivceScope = services.BuildServiceProvider())
        {
            var main = serivceScope.GetRequiredService<LoginView>();
            Application.Run(main);
        }
   
    }).Build();