using System.Threading.Tasks;

namespace NeoSqlOp.Data;

public interface INeoSqlOpDbSchemaMigrator
{
    Task MigrateAsync();
}
