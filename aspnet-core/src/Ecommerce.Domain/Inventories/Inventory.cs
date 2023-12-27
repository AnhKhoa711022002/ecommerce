using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Inventories
{
    public class Inventory : CreationAuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }
        public required string SKU { get; set; }
        public int StockQuantity { get; set; }
    }
}
