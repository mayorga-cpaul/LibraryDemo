using LibraryDemo.Client.Models;
using LIbraryDemo.Client.Common;
using LIbraryDemo.Client.Helpers;
using LIbraryDemo.Client.Interfaces;
using System.Net.Http.Headers;
using System.Text.Json;

namespace LIbraryDemo.Client.Services;

public class UserServices : IUserServices
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptionsWrapper _jsonSerializerOptionsWrapper;

    public UserServices(IHttpClientFactory httpClientFactory,
             JsonSerializerOptionsWrapper jsonSerializerOptionsWrapper)
    {
        _jsonSerializerOptionsWrapper = jsonSerializerOptionsWrapper ??
            throw new ArgumentNullException(nameof(jsonSerializerOptionsWrapper));
        _httpClientFactory = httpClientFactory ??
            throw new ArgumentNullException(nameof(httpClientFactory));
    }

    public async Task<User> AccessToAPI(Login login)
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        var serializedDocument = JsonSerializer.Serialize(
            login,
            _jsonSerializerOptionsWrapper.Options);

        var request = new HttpRequestMessage(HttpMethod.Post, "api/Account/Login");

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        request.Content = new StringContent(serializedDocument);

        request.Content.Headers.ContentType =
            new MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode) return null!;

        var result = await response.Content.ReadAsStringAsync();

        var user = JsonSerializer.Deserialize<User>(result,
            _jsonSerializerOptionsWrapper.Options);

        UserToken.Token = user!.Token;

        return user!;
    }

    public async Task<User> CreateUser(Register register)
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        var serializedDocument = JsonSerializer.Serialize(register,
            _jsonSerializerOptionsWrapper.Options);

        var request = new HttpRequestMessage(HttpMethod.Post, "api/Account/Register");

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        request.Content = new StringContent(serializedDocument);

        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode) return null!;

        var result = await response.Content.ReadAsStringAsync();
        var user = JsonSerializer.Deserialize<User>(result);

        return user!;
    }
}
