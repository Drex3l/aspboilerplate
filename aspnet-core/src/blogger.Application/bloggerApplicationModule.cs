using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using blogger.Authorization;

namespace blogger
{
    [DependsOn(
        typeof(bloggerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class bloggerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<bloggerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(bloggerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
