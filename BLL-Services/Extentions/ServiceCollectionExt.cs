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
        return services;
    }
}
