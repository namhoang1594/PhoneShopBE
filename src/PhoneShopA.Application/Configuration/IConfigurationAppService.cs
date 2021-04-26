using System.Threading.Tasks;
using PhoneShopA.Configuration.Dto;

namespace PhoneShopA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
