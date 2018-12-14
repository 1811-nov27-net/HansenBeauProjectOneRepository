using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class OrderHeader
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int StoreID { get; set; }

        public int AddressID { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime OrderDate { get; set; }


        // navigation property for Model.OrderDetail
        public List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
    }
}
