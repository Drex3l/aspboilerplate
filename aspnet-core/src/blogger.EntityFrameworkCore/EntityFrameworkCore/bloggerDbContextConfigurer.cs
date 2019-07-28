using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace blogger.EntityFrameworkCore
{
    public static class bloggerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<bloggerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<bloggerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
