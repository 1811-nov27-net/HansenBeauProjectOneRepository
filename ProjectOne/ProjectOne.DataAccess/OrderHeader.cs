using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int AddressId { get; set; }
        public decimal TotalCost { get; set; }
        // fix this typo if you have time
        public DateTime OrderData { get; set; }

        public virtual Address Address { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
