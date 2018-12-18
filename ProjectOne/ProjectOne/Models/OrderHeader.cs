using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class OrderHeader
    {
        [Display(Name = "Id")]
        public int OrderID { get; set; }

        public int StoreID { get; set; }

        public int AddressID { get; set; }

        public string StoreName { get; set; }

        public decimal TotalCost { get; set; }

        public List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();

        public List<Product> ProductList { get; set; }

    }
}
