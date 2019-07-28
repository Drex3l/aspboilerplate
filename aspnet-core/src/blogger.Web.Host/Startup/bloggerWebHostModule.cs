using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using blogger.Configuration;

namespace blogger.Web.Host.Startup
{
    [DependsOn(
       typeof(bloggerWebCoreModule))]
    public class bloggerWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public bloggerWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(bloggerWebHostModule).GetAssembly());
        }
    }
}
