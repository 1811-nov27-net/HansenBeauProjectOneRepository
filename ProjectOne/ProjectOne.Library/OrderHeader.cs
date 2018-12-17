using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Library
{
    public class OrderHeader
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int StoreID { get; set; }

        public int AddressID { get; set; }

        public decimal TotalCost { get; set; }

        public DateTime OrderDate { get; set; }

        public bool? Active { get; set; }

        public string AddToOrder(Library.Product product)
        {
            string returnString = "Product successfully added to order.";
            // Low performance implementation, however for small orders
            // which they are all less than 13, it shouldn't be too bad
            int numberProductsInOrder = 0;
            foreach (var item in OrderDetail)
            {
                numberProductsInOrder += item.QtyOrdered;
            }
            this.TotalCost += product.UnitPrice;

            if (numberProductsInOrder <= 12)
            {
                if (TotalCost <= 500)
                {
                    bool insert = true;
                    foreach (var item in OrderDetail)
                    {
                        if (item.ProductID == product.ProductID)
                        {
                            insert = false;
                            item.QtyOrdered++;
                        }
                    }
                    if (insert == true)
                    {
                        OrderDetail.Add(new OrderDetail() { ProductID = product.ProductID, QtyOrdered = 1 });
                    }
                }
                else
                {
                    this.TotalCost -= product.UnitPrice;
                    returnString = "Total Cost of order exceeds $500. Cannot add product to order.";
                }
            }
            else
            {
                returnString = "Number of products in an order cannot exceed 12. Cannot add product to order.";
            }
            return returnString;
        }

        // navigation property for Model.OrderDetail
        public List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
    }
}
