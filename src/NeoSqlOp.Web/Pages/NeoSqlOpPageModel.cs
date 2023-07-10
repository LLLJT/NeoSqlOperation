using NeoSqlOp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NeoSqlOp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NeoSqlOpPageModel : AbpPageModel
{
    protected NeoSqlOpPageModel()
    {
        LocalizationResourceType = typeof(NeoSqlOpResource);
    }
}
