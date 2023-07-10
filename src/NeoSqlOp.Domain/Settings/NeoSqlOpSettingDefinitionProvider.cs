using Volo.Abp.Settings;

namespace NeoSqlOp.Settings;

public class NeoSqlOpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NeoSqlOpSettings.MySetting1));
    }
}
