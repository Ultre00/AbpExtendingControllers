using AbpExtendingControllers.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpExtendingControllers
{
    [DependsOn(
        typeof(AbpExtendingControllersEntityFrameworkCoreTestModule)
        )]
    public class AbpExtendingControllersDomainTestModule : AbpModule
    {

    }
}