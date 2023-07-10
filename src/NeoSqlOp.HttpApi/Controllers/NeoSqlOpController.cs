using NeoSqlOp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NeoSqlOp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NeoSqlOpController : AbpControllerBase
{
    protected NeoSqlOpController()
    {
        LocalizationResource = typeof(NeoSqlOpResource);
    }
}
