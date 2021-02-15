using AbpExtendingControllers.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpExtendingControllers.Permissions
{
    public class AbpExtendingControllersPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpExtendingControllersPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpExtendingControllersPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpExtendingControllersResource>(name);
        }
    }
}
