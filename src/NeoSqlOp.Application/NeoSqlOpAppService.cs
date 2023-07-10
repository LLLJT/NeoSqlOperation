using System;
using System.Collections.Generic;
using System.Text;
using NeoSqlOp.Localization;
using Volo.Abp.Application.Services;

namespace NeoSqlOp;

/* Inherit your application services from this class.
 */
public abstract class NeoSqlOpAppService : ApplicationService
{
    protected NeoSqlOpAppService()
    {
        LocalizationResource = typeof(NeoSqlOpResource);
    }
}
