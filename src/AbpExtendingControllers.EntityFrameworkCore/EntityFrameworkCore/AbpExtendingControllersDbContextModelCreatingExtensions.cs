using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpExtendingControllers.EntityFrameworkCore
{
    public static class AbpExtendingControllersDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpExtendingControllers(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpExtendingControllersConsts.DbTablePrefix + "YourEntities", AbpExtendingControllersConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}