using ApiMicrosservicesProduct.Extensions.services;
namespace ApiMicrosservicesProduct.Extensions.database;

public static class InfraestructureModule
{
    public static IServiceCollection AddInfraEstructureModel(this IServiceCollection services,
              IConfiguration configuration)
    {
        return services.
             AddDbContextDependecyInjection(configuration)
            .AddRepositoryDependecyInjection()
            .AddServicesDependecyInjection();
    }
}
