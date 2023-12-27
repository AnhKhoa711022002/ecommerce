using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Products
{
    public class ProductReview : CreationAuditedEntity<Guid>
    {
        public Guid ProductId { get; set; }
        public Guid? ParentId { get; set; }
        public required string Title { get; set; }
        public double Rating { get; set; }
        public DateTime? PulishedDate { get; set; }
        public required string Content { get; set; }
        public Guid OrderId { get; set; }
    }
}
