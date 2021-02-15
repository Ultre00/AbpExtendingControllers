using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpExtendingControllers.Data
{
    /* This is used if database provider does't define
     * IAbpExtendingControllersDbSchemaMigrator implementation.
     */
    public class NullAbpExtendingControllersDbSchemaMigrator : IAbpExtendingControllersDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}