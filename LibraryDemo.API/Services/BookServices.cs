using LibraryDemo.API.Entities;
using LibraryDemo.API.Interfaces;

namespace LibraryDemo.API.Services;

public class BookServices : IBookServices
{
    private readonly IUnitOfWork unitOfWork;

    public BookServices(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public async Task CreateBookAsync(Book book)
    {
        if (book is null) new ArgumentNullException(nameof(book));
        bool exist = await ExistingAuthor(book!.AuthorId);
        
        if (!exist) 
            throw new ArgumentNullException(nameof(book.AuthorId), $"The author with Id {book.AuthorId} doesn't exist");

        await unitOfWork.Repository<Book>().InsertOneAsync(book);
    }

    public async Task DeleteBookAsync(string bookId)
    {
        await unitOfWork.Repository<Book>().DeleteOneAsync(e => e.Id.ToString() == bookId);
    }

    public async Task<bool> ExistingAuthor(string authorId)
    {
        return (await unitOfWork.Repository<Author>().FindOneAsync(e => e.Id.ToString() == authorId)) is null ? false : true;
    }

    public async Task<Book> GetBookByIdAsync(string bookId)
    {
        return await unitOfWork.Repository<Book>().FindOneAsync(e => e.Id.ToString() == bookId);
    }

    public async Task<List<Book>> ListBookAsync()
    {
        return await unitOfWork.Repository<Book>().ListAsync();
    }

    public async Task UpdateBookAsync(Book book)
    {
        await unitOfWork.Repository<Book>().ReplaceOneAsync(book);
    }
}
