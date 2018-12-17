using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Library
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DefaultAddressId { get; set; }

        public string CustomerPassword { get; set; }

        // navigation property for Model.Address
        public List<Address> Address { get; set; } = new List<Address>();

        // navigation property for Model.OrderHeader
        public List<OrderHeader> OrderHeader { get; set; } = new List<OrderHeader>();
    }
}
