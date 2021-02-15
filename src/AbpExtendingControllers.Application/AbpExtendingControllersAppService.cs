using System;
using System.Collections.Generic;
using System.Text;
using AbpExtendingControllers.Localization;
using Volo.Abp.Application.Services;

namespace AbpExtendingControllers
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpExtendingControllersAppService : ApplicationService
    {
        protected AbpExtendingControllersAppService()
        {
            LocalizationResource = typeof(AbpExtendingControllersResource);
        }
    }
}
