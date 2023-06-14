namespace LibraryDemo.API.Settings.DbConnection;

public interface IMongoDbSettings
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public string DatabaseName { get; set; }
    string ConnectionString { get; }
}
