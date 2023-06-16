using LibraryDemo.API.Dtos;
using LibraryDemo.API.Entities;
using LibraryDemo.API.Extensions;
using LibraryDemo.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDemo.API.Controllers;

public class BookController : BaseControllerApi
{
    private readonly IBookServices _bookServices;
    private readonly ILogger<BookController> _logger;
    
    public BookController(IBookServices bookServices, ILogger<BookController> logger)
    {
        _bookServices = bookServices;
        _logger = logger;
    }

    [Authorize]
    [HttpPost(nameof(CreateBook))]
    public async Task CreateBook(CreateBook book)
    {
        await _bookServices.CreateBookAsync(book.AsEntity());
    }

    [Authorize]
    [HttpGet("{bookId}", Name = nameof(GetBookById))]
    public async Task<ActionResult<BookDto>> GetBookById(string bookId)
    {
        var result = await _bookServices.GetBookByIdAsync(bookId);
        if (result == null) NotFound($"The book with id {bookId} not was found");

        return Ok(result?.AsDto());
    }

    [Authorize]
    [HttpGet(Name = nameof(GetBooks))]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks()
    {
        var results = await _bookServices.ListBookAsync();
        _logger.LogInformation($"Executing: {nameof(GetBooks)}");
        return Ok(results.AsListDto());
    }

    [Authorize]
    [HttpPatch("{bookId}", Name = nameof(UpdateBook))]
    public async Task<ActionResult<AuthorDto>> UpdateBook([FromBody]JsonPatchDocument
        <Book> updateBook, string bookId)
    {
        var existingBook = await _bookServices.GetBookByIdAsync(bookId);

        if (existingBook is null) return NotFound();

        if (!(existingBook is null))
            updateBook.ApplyTo(existingBook, ModelState);

        if (!TryValidateModel(updateBook))
            return BadRequest(ModelState);

        await _bookServices.UpdateBookAsync(existingBook!);
        _logger.LogInformation($"Book updated: {existingBook!.Id.ToString()}");

        return Ok(existingBook.AsDto());
    }
}
