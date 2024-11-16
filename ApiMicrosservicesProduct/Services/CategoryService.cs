using ApiMicrosservicesProduct.Dtos;
using ApiMicrosservicesProduct.Models;
using ApiMicrosservicesProduct.Models.Interfaces;
using ApiMicrosservicesProduct.Services.Interfaces;
using AutoMapper;

namespace ApiMicrosservicesProduct.Services;

public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;
    private readonly IMapper _mapper = mapper;

    public Task AddAsync(ProductDto entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDto> GetByIdAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDto>> GetItemsAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(ProductDto entity)
    {
        throw new NotImplementedException();
    }
}
