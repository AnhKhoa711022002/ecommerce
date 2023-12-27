using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        public required string Code { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double ShippingFee { get; set; }
        public double Tax {  get; set; }
        public double Total {  get; set; }
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double GrandTotal { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerPhoneNumber { get; set; }
        public required string CustomerAddress { get; set;}
        public Guid? CustomerId { get; set; }
    }
}
