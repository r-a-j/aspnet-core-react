using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ReactTest.EntityFrameworkCore
{
    public static class ReactTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReactTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReactTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
