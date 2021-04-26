using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PhoneShopA.Configuration.Dto;

namespace PhoneShopA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhoneShopAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
