using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using PhoneShopA.Authorization;
using PhoneShopA.Domain;
using PhoneShopA.Services.Dto;
using PhoneShopA.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Services
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, int, PagedAndSortedResultRequestDto, ProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}