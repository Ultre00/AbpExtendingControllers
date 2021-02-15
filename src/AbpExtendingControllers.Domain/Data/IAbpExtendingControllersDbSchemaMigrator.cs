using System.Threading.Tasks;

namespace AbpExtendingControllers.Data
{
    public interface IAbpExtendingControllersDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
