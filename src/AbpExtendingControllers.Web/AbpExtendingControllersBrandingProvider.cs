using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpExtendingControllers.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpExtendingControllersBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpExtendingControllers";
    }
}
