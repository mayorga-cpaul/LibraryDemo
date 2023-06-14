using LibraryDemo.API.Entities;
using LibraryDemo.API.Interfaces;
using LibraryDemo.API.Settings.DbConnection;
using LibraryDemo.Infraestructure.Data;
using MongoDB.Driver;
using System.Collections;

namespace LibraryDemo.API.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly IMongoClient _mongoClient;
    private readonly IMongoDbSettings _mongoDbSettings;
    private Hashtable? _repositories;

    public UnitOfWork(IMongoClient mongoClient, IMongoDbSettings mongoDbSettings)
    {
        _mongoClient = mongoClient;
        _mongoDbSettings = mongoDbSettings;
    }

    public void Dispose()
    {
        this.Dispose();
    }

    public IMongoRepository<TDocument> Repository<TDocument>() where TDocument : Document
    {
        if (_repositories is null) _repositories = new Hashtable();

        var type = typeof(TDocument).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(MongoRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TDocument)), _mongoClient, _mongoDbSettings);

            _repositories.Add(type, repositoryInstance);
        }

        return (IMongoRepository<TDocument>) _repositories[type]!;
    }
}