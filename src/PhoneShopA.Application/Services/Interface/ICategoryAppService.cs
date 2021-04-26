using Abp.Application.Services;
using PhoneShopA.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Services.Interface
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto>
    {
    }
}
