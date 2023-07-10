using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NeoSqlOp.Data;
using Volo.Abp.DependencyInjection;

namespace NeoSqlOp.EntityFrameworkCore;

public class EntityFrameworkCoreNeoSqlOpDbSchemaMigrator
    : INeoSqlOpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNeoSqlOpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NeoSqlOpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NeoSqlOpDbContext>()
            .Database
            .MigrateAsync();
    }
}
