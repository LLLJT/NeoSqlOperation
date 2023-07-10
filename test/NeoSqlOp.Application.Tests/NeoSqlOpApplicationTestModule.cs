using Volo.Abp.Modularity;

namespace NeoSqlOp;

[DependsOn(
    typeof(NeoSqlOpApplicationModule),
    typeof(NeoSqlOpDomainTestModule)
    )]
public class NeoSqlOpApplicationTestModule : AbpModule
{

}
