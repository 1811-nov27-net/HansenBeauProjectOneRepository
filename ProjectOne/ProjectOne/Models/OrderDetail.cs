using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int QtyOrdered { get; set; }

    }
}
