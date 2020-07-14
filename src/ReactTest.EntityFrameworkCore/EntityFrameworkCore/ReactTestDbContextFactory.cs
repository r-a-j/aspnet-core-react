using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReactTest.Configuration;
using ReactTest.Web;

namespace ReactTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReactTestDbContextFactory : IDesignTimeDbContextFactory<ReactTestDbContext>
    {
        public ReactTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReactTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReactTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReactTestConsts.ConnectionStringName));

            return new ReactTestDbContext(builder.Options);
        }
    }
}
