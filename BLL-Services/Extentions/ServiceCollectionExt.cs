using BLL_Services.Interfaces;
using BLL_Services.Services;
using BLL_Services.Services.BuilderServices;
using DB_Conection_Models.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Extentions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddScoped<PCBuilderService>();
        services.AddScoped<IService<PC>, PCService >();

        return services;
    }
}
