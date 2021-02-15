using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpExtendingControllers.Data;
using Volo.Abp.DependencyInjection;

namespace AbpExtendingControllers.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpExtendingControllersDbSchemaMigrator
        : IAbpExtendingControllersDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpExtendingControllersDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpExtendingControllersMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpExtendingControllersMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}