using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneShopA.EntityFrameworkCore;
using PhoneShopA.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PhoneShopA.Web.Tests
{
    [DependsOn(
        typeof(PhoneShopAWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PhoneShopAWebTestModule : AbpModule
    {
        public PhoneShopAWebTestModule(PhoneShopAEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoneShopAWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PhoneShopAWebMvcModule).Assembly);
        }
    }
}