using BLL_Services.Services;
using BLL_Services.Services.BuilderServices;
using Microsoft.Extensions.DependencyInjection;

namespace BLL_Services.Extentions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddScoped<PCBuilderService>();
        services.AddScoped<PCService>();
        services.AddScoped<PCComponentService>();

        return services;
    }
}
