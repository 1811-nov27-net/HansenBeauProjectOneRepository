using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int QtyOrdered { get; set; }

        public virtual OrderHeader Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
