using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PhoneShopA.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Services.Dto
{
    [AutoMapFrom(typeof(Category))]
    [AutoMapTo(typeof(Category))]
    public class CategoryDto : EntityDto<int>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}