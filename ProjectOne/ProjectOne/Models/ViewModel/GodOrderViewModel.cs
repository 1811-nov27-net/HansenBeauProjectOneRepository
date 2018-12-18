using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models.ViewModel
{
    public class GodOrderViewModel
    {
        public int StoreId { get; set; }

        public int AddressId { get; set; }

        public List<Product> ProductList { get; set; }

    }
}
