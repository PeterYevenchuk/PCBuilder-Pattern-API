﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DB_Conection_Models.Context;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PCDbContext>
{
    public PCDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath("D:\\MyCodeC#.NET\\Git\\PCBuilder-Patterns-API\\PC-Builder-Decorator-Pattern\\PC-Builder-DecoratorPattern")
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("PC-DB");

        var optionsBuilder = new DbContextOptionsBuilder<PCDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new PCDbContext(optionsBuilder.Options);
    }
}
