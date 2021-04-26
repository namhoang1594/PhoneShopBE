using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhoneShopA.Configuration;
using PhoneShopA.Web;

namespace PhoneShopA.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneShopADbContextFactory : IDesignTimeDbContextFactory<PhoneShopADbContext>
    {
        public PhoneShopADbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneShopADbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneShopADbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneShopAConsts.ConnectionStringName));

            return new PhoneShopADbContext(builder.Options);
        }
    }
}
