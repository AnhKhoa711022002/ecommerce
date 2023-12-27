using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Attributes
{
    public class Attribute : CreationAuditedAggregateRoot<Guid>
    {
        public required string Code { get; set; }
        public AttributeType DataType { get; set; }
        public required string Label { get; set; }
        public int SortOrder { get; set; }
        public bool Visibility { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public bool InUnique { get; set; }
        public required string Note { get; set; }
    }
}
