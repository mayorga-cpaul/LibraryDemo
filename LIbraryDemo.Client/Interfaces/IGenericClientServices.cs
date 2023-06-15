namespace LIbraryDemo.Client.Interfaces;

public interface IGenericClientServices <TDocument>
    where TDocument : class
{
    Task<IEnumerable<TDocument>> ListAsync();

}
