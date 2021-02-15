using Volo.Abp.Settings;

namespace AbpExtendingControllers.Settings
{
    public class AbpExtendingControllersSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpExtendingControllersSettings.MySetting1));
        }
    }
}
