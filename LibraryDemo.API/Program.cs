using LibraryDemo.API.Extensions;
using LibraryDemo.API.MIddlewares;
using LibraryDemo.API.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddServices(builder.Configuration);

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, MyJPIF.GetJsonPatchInputFormatter());
}).AddNewtonsoftJson();

builder.Services.AddSwaggerDocumentation();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<ExceptionMiddleware>();
app.UseStatusCodePagesWithReExecute("/errors/{0}");

// Configure the HTTP request pipeline.
app.UseSwaggerDocumentation();

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
