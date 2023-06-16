using LIbraryDemo.Client.Common;
using LIbraryDemo.Client.Helpers;
using LIbraryDemo.Client.Interfaces;
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
        var uri = $"api/{typeof(TDocument).Name}/{typeof(TCreate).Name}";
        var request = new HttpRequestMessage(
           HttpMethod.Post,
           uri);

        httpClient.DefaultRequestHeaders.Authorization = 
            new AuthenticationHeaderValue("Bearer", UserToken.Token);

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        request.Content = new StringContent(serializedDocument);
        request.Content.Headers.ContentType =
            new MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteAsync(string documentId)
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        var uri = $"api/{typeof(TDocument).Name}/{documentId}";
        var request = new HttpRequestMessage(
            HttpMethod.Delete,uri
            );
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + UserToken.Token);

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
    }

    public async Task<List<TDocument>> ListAsync()
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        httpClient.DefaultRequestHeaders.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + UserToken.Token);
        var uri = $"api/{typeof(TDocument).Name}";

        var response = await httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        
        return JsonSerializer.Deserialize<List<TDocument>>(
            content,
            _jsonSerializerOptionsWrapper.Options)!;
    }

    public async Task<TDocument> UpdateAsync(TCreate author, string authorId)
    {
        var httpClient = _httpClientFactory.CreateClient("LibraryAPIClientDemo");

        var documentToUpdate = JsonSerializer.Serialize(
            author,
            _jsonSerializerOptionsWrapper.Options);

        var uri = $"api/{typeof(TDocument).Name}/{authorId}";
        var request = new HttpRequestMessage(
           HttpMethod.Put,uri
           );
        httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + UserToken.Token);

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        request.Content = new StringContent(documentToUpdate);
        request.Content.Headers.ContentType =
            new MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var documentUpdated = JsonSerializer.Deserialize<TDocument>(
            content,
            _jsonSerializerOptionsWrapper.Options);

        return documentUpdated!;
    }
}
