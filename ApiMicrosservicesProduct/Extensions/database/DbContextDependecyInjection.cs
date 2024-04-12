using Microsoft.EntityFrameworkCore;


namespace ApiMicrosservicesProduct.Extensions.database;

public static class DbContextDependecyInjection
{
    public static IServiceCollection AddDbContextDependecyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<AppDbContext>(options
            => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));
    }
}
