using Abp.Application.Services;
using PhoneShopA.MultiTenancy.Dto;

namespace PhoneShopA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

