using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Manufacturers
{
    public class Manufacturer : CreationAuditedAggregateRoot<Guid>
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Slug { get; set; }   
        public required string CoverPicture { get; set;}
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public required string CoverPicturey { get; set; }
    }
}
