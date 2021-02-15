using AbpExtendingControllers.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpExtendingControllers.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpExtendingControllersEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpExtendingControllersApplicationContractsModule)
        )]
    public class AbpExtendingControllersDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
