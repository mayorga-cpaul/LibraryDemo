using LIbraryDemo.Client.Helpers;
using LIbraryDemo.Client.Interfaces;
using Microsoft.VisualBasic.Devices;
using System.Net.Http.Headers;
using System.Text.Json;

namespace LIbraryDemo.Client.Services;

public class GenericClientServices<TDocument, TCreate> : IGenericClientServices<TDocument, TCreate>
    where TDocument : IDocument where TCreate : ICreateDocument
{
    
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptionsWrapper _jsonSerializerOptionsWrapper;

    public GenericClientServices(IHttpClientFactory httpClientFactory,
             JsonSerializerOptionsWrapper jsonSerializerOptionsWrapper)
    {
        _jsonSerializerOptionsWrapper = jsonSerializerOptionsWrapper ??
            throw new ArgumentNullException(nameof(jsonSerializerOptionsWrapper));
        _httpClientFactory = httpClientFactory ??
            throw new ArgumentNullException(nameof(httpClientFactory));
    }

    public async Task CreateAsync(TCreate createDocument)
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        var serializedDocument = JsonSerializer.Serialize(
            createDocument,
            _jsonSerializerOptionsWrapper.Options);

        var request = new HttpRequestMessage(
           HttpMethod.Post,
           "api/movies");

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        request.Content = new StringContent(serializedDocument);
        request.Content.Headers.ContentType =
            new MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        throw new NotImplementedException();
    }

    public async Task<IEnumerable<TDocument>> ListAsync()
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        httpClient.DefaultRequestHeaders.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.Accept.Add(
           new MediaTypeWithQualityHeaderValue(
               "application/xml",
               0.9));

        var response = await httpClient.GetAsync($"api/{typeof(TDocument).Name}");

        if (!response.IsSuccessStatusCode) return null!;
        var content = await response.Content.ReadAsStringAsync();
        var movies = new List<TDocument>();
        movies = JsonSerializer.Deserialize<List<TDocument>>(
            content,
            _jsonSerializerOptionsWrapper.Options);

        return movies!;
    }
}
