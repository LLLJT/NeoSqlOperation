using NeoSqlOp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NeoSqlOp;

[DependsOn(
    typeof(NeoSqlOpEntityFrameworkCoreTestModule)
    )]
public class NeoSqlOpDomainTestModule : AbpModule
{

}
