using Application.Abstractions.Data;
using Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Interceptors;
using Persistence.Repositories;
using SharedKernel;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options
            .UseNpgsql(configuration.GetConnectionString("FreshMarketDbConnectionString")));

        services.AddScoped<IApplicationDbContext>(sp =>
            sp.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<IUnitOfWork>(sp =>
            sp.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<EntitySaveChangesInterceptor>();

        services.AddScoped<DispatchDomainEventsInterceptor>();

        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        services.AddScoped<ICategoryRepository, CategoryRepository>();

        return services;
    }
}
