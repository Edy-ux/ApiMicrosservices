﻿namespace ApiMicrosservicesProduct.Services.Interfaces;

public interface IGenericService<T> where T : class 
{
    Task<IEnumerable<T>> GetItemsAsync();
    Task<T> GetByIdAsync(int? id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int? id);
}
