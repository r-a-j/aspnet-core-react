using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReactTest.Configuration;

namespace ReactTest.Web.Host.Startup
{
    [DependsOn(
       typeof(ReactTestWebCoreModule))]
    public class ReactTestWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReactTestWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReactTestWebHostModule).GetAssembly());
        }
    }
}
