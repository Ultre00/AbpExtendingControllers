using Volo.Abp.Modularity;

namespace AbpExtendingControllers
{
    [DependsOn(
        typeof(AbpExtendingControllersApplicationModule),
        typeof(AbpExtendingControllersDomainTestModule)
        )]
    public class AbpExtendingControllersApplicationTestModule : AbpModule
    {

    }
}