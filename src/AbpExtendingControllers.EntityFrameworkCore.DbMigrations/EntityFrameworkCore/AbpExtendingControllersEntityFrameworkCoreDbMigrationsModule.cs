using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpExtendingControllers.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpExtendingControllersEntityFrameworkCoreModule)
        )]
    public class AbpExtendingControllersEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpExtendingControllersMigrationsDbContext>();
        }
    }
}
