using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Ecommerce.Promotions
{
    public class PromtionUsageHistory : Entity<Guid>
    {
        public Guid PromotionId { get; set; }
        public Guid OrderId { get; set; }
    }
}
