using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace NeoSqlOp.Web;

[Dependency(ReplaceServices = true)]
public class NeoSqlOpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NeoSqlOp";
}
