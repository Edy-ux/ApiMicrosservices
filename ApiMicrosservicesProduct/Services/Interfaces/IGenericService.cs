namespace ApiMicrosservicesProduct.Services.Interfaces;

public interface IGenericService<T> where T : class 
{
    Task<IEnumerable<T>> GetItemsAsync();
    Task<T> GetByIdAsync(int? id);
    Task<T> AddAsync(T entity);
    Task<T> UpDateAsync(T entity);
    Task<T> DeteleAsync(int? Id);
}
