using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using blogger.Configuration;
using blogger.Web;

namespace blogger.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class bloggerDbContextFactory : IDesignTimeDbContextFactory<bloggerDbContext>
    {
        public bloggerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<bloggerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            bloggerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(bloggerConsts.ConnectionStringName));

            return new bloggerDbContext(builder.Options);
        }
    }
}
