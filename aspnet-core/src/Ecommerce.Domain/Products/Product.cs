using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public Guid ManufacturerId { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public ProductType ProductType { get; set; }
        public required string SKU { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public required string SeoMetaDescription { get; set; }
        public required string Description { get; set; }
        public required string ThumbnailPicture {  get; set; }
    }
}
