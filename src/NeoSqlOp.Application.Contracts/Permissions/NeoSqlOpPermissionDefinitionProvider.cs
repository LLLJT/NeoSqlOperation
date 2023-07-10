using NeoSqlOp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NeoSqlOp.Permissions;

public class NeoSqlOpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NeoSqlOpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NeoSqlOpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NeoSqlOpResource>(name);
    }
}
