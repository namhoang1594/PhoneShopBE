﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoneShopA.Authorization;

namespace PhoneShopA
{
    [DependsOn(
        typeof(PhoneShopACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneShopAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneShopAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhoneShopAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
