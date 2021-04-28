using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneShopA.Authorization;
using PhoneShopA.Domain;
using PhoneShopA.Services.Dto;
using PhoneShopA.Services.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Services
{
    [AbpAuthorize(PermissionNames.Pages_Blogs)]
    public class BlogAppService : AsyncCrudAppService<Blog, BlogDto, int, PagedAndSortedResultRequestDto>, IBlogAppService
    {
        public BlogAppService(IRepository<Blog, int> repository) : base(repository)
        {
        }
        //[HttpPost]
        //[Consumes("multipart/form-data")]
        //public async Task UploadFiles([FromForm]IFormFile file, BlogDto input)
        //{
        //    var uploads = Path.Combine("ROOT PATH FOR THE FILES", "uploads");

        //    if (file.Length > 0)
        //    {
        //        var filePath = Path.Combine(uploads, file.FileName);

        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            file.CopyTo(fileStream);
        //        }
        //    }
        //}
    }
}