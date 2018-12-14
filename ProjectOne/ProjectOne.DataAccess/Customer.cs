using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Customer
    {
        public Customer()
        {
            Address = new HashSet<Address>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DefaultAddressId { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
