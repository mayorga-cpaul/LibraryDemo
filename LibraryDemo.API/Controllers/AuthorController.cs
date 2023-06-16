using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using LibraryDemo.API.Extensions;
using LibraryDemo.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDemo.API.Controllers;

public class AuthorController : BaseControllerApi
{
    private readonly IMongoRepository<Author> _authorRepository;
    private readonly ILogger<AuthorController> _logger;
    public AuthorController(IMongoRepository<Author> authorRepository, ILogger<AuthorController> logger)
    {
        _authorRepository = authorRepository;
        _logger = logger;
    }

    [Authorize]
    [HttpPost(nameof(CreateAuthor))]
    public async Task CreateAuthor(CreateAuthor author)
    {
        await _authorRepository.InsertOneAsync(author.AsEntity());
    }

    [Authorize]
    [HttpGet("{authorId}", Name = nameof(GetAuthorById))]
    public async Task<ActionResult<AuthorDto>> GetAuthorById(string authorId)
    {
        var result = await _authorRepository.FindByIdAsync(authorId);
        if (result == null) NotFound($"The author with id {authorId} not was found");

        return Ok(result?.AsDto());
    }

    [Authorize]
    [HttpGet(Name = nameof(GetAuthors))]
    public async Task<ActionResult<IEnumerable<AuthorDto>>> GetAuthors()
    {
        var results = await _authorRepository.ListAsync();
        _logger.LogInformation($"Executing: {nameof(GetAuthors)}");
        return Ok(results.AsListDto());
    }

    [Authorize]
    [HttpPatch("{authorId}", Name = nameof(UpdateAuthor))]
    public async Task<ActionResult<AuthorDto>> UpdateAuthor([FromBody]JsonPatchDocument
        <Author> updateAuthor, string authorId)
    {
        var existingAuthor = await _authorRepository.FindByIdAsync(authorId);
        
        if (existingAuthor is null) return NotFound();

        if (!(existingAuthor is null))
            updateAuthor.ApplyTo(existingAuthor, ModelState);
   
        if (!TryValidateModel(updateAuthor))
            return BadRequest(ModelState);

        await _authorRepository.ReplaceOneAsync(existingAuthor!);
        _logger.LogInformation($"Author updated: {existingAuthor!.Id.ToString()}");

        return Ok(existingAuthor.AsDto());
    }

    [Authorize]
    [HttpDelete("{authorId}")]
    public async Task DeleteAuthor(string authorId)
    {
        await _authorRepository.DeleteByIdAsync(authorId);
    }

    [Authorize]
    [HttpPut("{authorId}")]
    public async Task<ActionResult<AuthorDto>> DeleteAuthor(string authorId, [FromBody] UpdateAuthor updateAuthor)
    {
        var existingAuthor = await _authorRepository.FindByIdAsync(authorId);
        if (existingAuthor is null) return NotFound();

        existingAuthor.Name = updateAuthor.Name;
        existingAuthor.Name = updateAuthor.Nationality;

        await _authorRepository.ReplaceOneAsync(existingAuthor);

        return Ok(existingAuthor.AsDto());
    }
}
