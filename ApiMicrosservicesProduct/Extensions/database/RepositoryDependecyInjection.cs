using ApiMicrosservicesProduct.Context.Repositories;
using ApiMicrosservicesProduct.Models.Interfaces;

namespace ApiMicrosservicesProduct.Extensions.database;

public static class RepositoryDependecyInjection
{
    public static IServiceCollection AddRepositoryDependecyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;

    }
}
