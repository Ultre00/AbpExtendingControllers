using AbpExtendingControllers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpExtendingControllers.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpExtendingControllersController : AbpController
    {
        protected AbpExtendingControllersController()
        {
            LocalizationResource = typeof(AbpExtendingControllersResource);
        }
    }
}