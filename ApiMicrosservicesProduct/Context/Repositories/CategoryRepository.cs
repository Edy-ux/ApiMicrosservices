using ApiMicrosservicesProduct.Models;
using ApiMicrosservicesProduct.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiMicrosservicesProduct.Context.Repositories;

public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
{

    private readonly AppDbContext _context = appDbContext;


    public async Task<IEnumerable<Category>> GetItemsAsync()
    {
        return await _context.Categories
                .AsNoTracking()
                .Include(x => x.Products)
                .ToListAsync();
    }
    public async Task<Category> GetByIdAsync(int? id)
    {
        return await _context.Categories.
                       AsNoTracking()
                      .Include(x => x.Products)
                      .SingleOrDefaultAsync(x => x.Id == id);

    }

    public async Task<Category> CreateAsync(Category entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;

    }


    public async Task<Category> RemoveAsync(Category entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;

    }

    public async Task<Category> UpdateAsync(Category entity)
    {

        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
