using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PhoneShopA.EntityFrameworkCore
{
    public static class PhoneShopADbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneShopADbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PhoneShopADbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
