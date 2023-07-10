using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NeoSqlOp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NeoSqlOpDbContextFactory : IDesignTimeDbContextFactory<NeoSqlOpDbContext>
{
    public NeoSqlOpDbContext CreateDbContext(string[] args)
    {
        NeoSqlOpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NeoSqlOpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new NeoSqlOpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NeoSqlOp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
