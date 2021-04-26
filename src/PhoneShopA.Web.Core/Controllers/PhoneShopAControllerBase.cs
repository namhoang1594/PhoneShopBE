using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PhoneShopA.Controllers
{
    public abstract class PhoneShopAControllerBase: AbpController
    {
        protected PhoneShopAControllerBase()
        {
            LocalizationSourceName = PhoneShopAConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
