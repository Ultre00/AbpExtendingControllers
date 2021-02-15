using AbpExtendingControllers.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpExtendingControllers.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpExtendingControllersPageModel : AbpPageModel
    {
        protected AbpExtendingControllersPageModel()
        {
            LocalizationResourceType = typeof(AbpExtendingControllersResource);
        }
    }
}