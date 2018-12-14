using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
            ProductRecipe = new HashSet<ProductRecipe>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<ProductRecipe> ProductRecipe { get; set; }
    }
}
