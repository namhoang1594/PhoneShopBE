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
    [AutoMapFrom(typeof(Product))]
    [AutoMapTo(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
        public string Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}