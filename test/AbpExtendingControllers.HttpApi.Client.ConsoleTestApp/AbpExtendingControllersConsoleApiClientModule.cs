using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpExtendingControllers.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpExtendingControllersHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpExtendingControllersConsoleApiClientModule : AbpModule
    {
        
    }
}
