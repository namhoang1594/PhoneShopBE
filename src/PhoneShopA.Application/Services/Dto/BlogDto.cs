using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using PhoneShopA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Services.Dto
{
    [AutoMapFrom(typeof(Blog))]
    [AutoMapTo(typeof(Blog))]
    public class BlogDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string TypeofDocument { get; set; }
        public string ShortContents { get; set; }
        public string MainContents { get; set; }
        public string Description { get; set; }
        //public IFormFile Images { get; set; }
        public string Images { get; set; }
    }
}