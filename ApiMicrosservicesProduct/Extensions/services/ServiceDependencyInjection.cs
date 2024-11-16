using ApiMicrosservicesProduct.Dtos.Mappings;
using ApiMicrosservicesProduct.Services;
using ApiMicrosservicesProduct.Services.Interfaces;


namespace ApiMicrosservicesProduct.Extensions.services;
public static class ServicesDependecyInjection
{
    public static IServiceCollection AddServicesDependecyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddAutoMapper(typeof(MappingProfile));

        return services;
    }
}