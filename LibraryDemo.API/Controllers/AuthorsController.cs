using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using LibraryDemo.API.Extensions;
using LibraryDemo.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDemo.API.Controllers;

public class AuthorsController : BaseControllerApi
{
    private readonly IMongoRepository<Author> _authorRepository;
    private readonly ILogger<AuthorsController> _logger;
    public AuthorsController(IMongoRepository<Author> authorRepository, ILogger<AuthorsController> logger)
    {
        _authorRepository = authorRepository;
        _logger = logger;
    }

    [Authorize]
    [HttpPost(Name = nameof(CreateAuthor))]
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
}
