using Abp.Application.Services.Dto;

namespace PhoneShopA.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

