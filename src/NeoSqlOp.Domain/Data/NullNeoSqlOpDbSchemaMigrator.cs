using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NeoSqlOp.Data;

/* This is used if database provider does't define
 * INeoSqlOpDbSchemaMigrator implementation.
 */
public class NullNeoSqlOpDbSchemaMigrator : INeoSqlOpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
