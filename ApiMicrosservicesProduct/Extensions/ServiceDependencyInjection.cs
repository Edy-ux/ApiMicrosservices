using ApiMicrosservicesProduct.Dtos.Mappings;
using ApiMicrosservicesProduct.Services;
using ApiMicrosservicesProduct.Services.Interfaces;


namespace ApiMicrosservicesProduct.Extensions;
public static class ServicesDependecyInjection
{
    public static IServiceCollection AddServicesDependecyInjection(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryDtoService>();
        services.AddScoped<IProductService, ProductDtoService>();
        services.AddAutoMapper(typeof(MappingProfile));

        return services;
    }
}