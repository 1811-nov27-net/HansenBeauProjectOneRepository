using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Address
    {
        public Address()
        {
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
