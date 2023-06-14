using LibraryDemo.API.Entities;

namespace LibraryDemo.API.Interfaces;

public interface IUnitOfWork
{
    IMongoRepository<TEntity> Repository<TEntity>() where TEntity : Document;
}
