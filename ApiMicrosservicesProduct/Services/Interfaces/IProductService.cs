using ApiMicrosservicesProduct.Dtos;
using ApiMicrosservicesProduct.Models;

namespace ApiMicrosservicesProduct.Services.Interfaces;

public interface IProductService : IGenericService<ProductDto>
{
    Task<IEnumerable<ProductDto>> GetSearchProductsAsync(string keyword);
    Task<IEnumerable<ProductDto>> GetProductsByCategoriesAsync(string categoryStr);
}
