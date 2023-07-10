using NeoSqlOp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace NeoSqlOp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NeoSqlOpEntityFrameworkCoreModule),
    typeof(NeoSqlOpApplicationContractsModule)
    )]
public class NeoSqlOpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
