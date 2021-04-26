using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneShopA.Configuration;

namespace PhoneShopA.Web.Host.Startup
{
    [DependsOn(
       typeof(PhoneShopAWebCoreModule))]
    public class PhoneShopAWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoneShopAWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneShopAWebHostModule).GetAssembly());
        }
    }
}
