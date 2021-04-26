using System.Threading.Tasks;
using Abp.Application.Services;
using PhoneShopA.Sessions.Dto;

namespace PhoneShopA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
