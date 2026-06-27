using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InventoryManagement.Infrastructure.Data;
using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Infrastructure.Repositories;

namespace InventoryManagement.Infrastructure.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        // AddScoped: Create one instance per request/circuit scope.
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}