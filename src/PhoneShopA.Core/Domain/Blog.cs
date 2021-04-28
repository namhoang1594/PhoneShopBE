using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShopA.Domain
{
    public class Blog : Entity<int>
    {
        public string Title { get; set; }
        public string TypeofDocument { get; set; }
        public string ShortContents { get; set; }
        public string MainContents { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }

    }
}