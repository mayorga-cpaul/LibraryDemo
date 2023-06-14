namespace LibraryDemo.API.Settings.DbConnection;

public class MongoDbSettings : IMongoDbSettings
{
    public string Host { get; set; } = string.Empty;
    public int Port { get; set; }
    public string User { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;

    public string ConnectionString
    {
        get
        {
            return $"mongodb://{User}:{Password}@{Host}:{Port}";
        }
    }
}
