using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReactTest.Authorization;

namespace ReactTest
{
    [DependsOn(
        typeof(ReactTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReactTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReactTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReactTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
