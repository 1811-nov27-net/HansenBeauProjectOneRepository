using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Store
    {
        public Store()
        {
            Inventory = new HashSet<Inventory>();
            OrderHeader = new HashSet<OrderHeader>();
        }

        public int StoreId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<OrderHeader> OrderHeader { get; set; }
    }
}
