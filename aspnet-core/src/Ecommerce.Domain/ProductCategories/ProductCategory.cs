using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.ProductCategories
{
    public class ProductCategory : CreationAuditedAggregateRoot<Guid>
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public required string Description { get; set; }
        public int SortOrder { get; set; }
        public required string CoverPicture {  get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid? ParentId { get; set; }
        public required string SeoMetaDescription { get; set; }
    }
}
