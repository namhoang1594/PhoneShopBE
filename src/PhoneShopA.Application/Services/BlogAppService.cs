using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Http;
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
    [AbpAuthorize(PermissionNames.Pages_Blogs)]
    public class BlogAppService : AsyncCrudAppService<Blog, BlogDto, Guid, PagedAndSortedResultRequestDto>, IBlogAppService
    {
        public BlogAppService(IRepository<Blog, Guid> repository) : base(repository)
        {
        }
    }
}