using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DA = ProjectOne.DataAccess;

namespace ProjectOne
{
    public class ManualMapper
    {
        // All address mappings
        public static Models.Address ManMap(DA.Address address) => new Models.Address
        {
            AddressId = address.AddressId,
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            State = address.State,
            ZIP = address.Zip,
            CustomerID = address.CustomerId
        };
        public static DA.Address ManMap(Models.Address address) => new DA.Address
        {
            AddressId = address.AddressId,
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            State = address.State,
            Zip = address.ZIP,
            CustomerId = address.CustomerID
        };
        public static IEnumerable<Models.Address> ManMap(IEnumerable<DA.Address> address) => address.Select(ManMap);
        public static IEnumerable<DA.Address> ManMap(IEnumerable<Models.Address> address) => address.Select(ManMap);

        // All customer mappings
        public static Models.Customer ManMap(DA.Customer customer) => new Models.Customer
        {
            CustomerID = customer.CustomerId,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DefaultAddressId = customer.DefaultAddressId
        };
        public static DA.Customer ManMap(Models.Customer customer) => new DA.Customer
        {
            CustomerId = customer.CustomerID,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DefaultAddressId = customer.DefaultAddressId
        };
        public static IEnumerable<Models.Customer> ManMap(IEnumerable<DA.Customer> customer) => customer.Select(ManMap);
        public static IEnumerable<DA.Customer> ManMap(IEnumerable<Models.Customer> customer) => customer.Select(ManMap);
        //List-to-List mappings included to help with RepositpryDB.GetCustomers(params string[] names) method
        public static List<Models.Customer> ManMap(List<DA.Customer> customer) => customer.Select(ManMap).ToList();
        public static List<DA.Customer> ManMap(List<Models.Customer> customer) => customer.Select(ManMap).ToList();

        // All ingredient mappings
        public static Models.Ingredient ManMap(DA.Ingredient ingredient) => new Models.Ingredient
        {
            IngredientID = ingredient.IngredientId,
            IngredientName = ingredient.IngredientName,
            IngredientPrice = ingredient.IngredientPrice
        };
        public static DA.Ingredient ManMap(Models.Ingredient ingredient) => new DA.Ingredient
        {
            IngredientId = ingredient.IngredientID,
            IngredientName = ingredient.IngredientName,
            IngredientPrice = ingredient.IngredientPrice
        };
        public static IEnumerable<Models.Ingredient> ManMap(IEnumerable<DA.Ingredient> ingredient) => ingredient.Select(ManMap);
        public static IEnumerable<DA.Ingredient> ManMap(IEnumerable<Models.Ingredient> ingredient) => ingredient.Select(ManMap);

        // All inventory mappings
        public static Models.Inventory ManMap(DA.Inventory inventory) => new Models.Inventory
        {
            InventoryID = inventory.InventoryId,
            IngredientID = inventory.IngredientId,
            StoreID = inventory.StoreId,
            QtyRemaining = inventory.QtyRemaining
        };
        public static DA.Inventory ManMap(Models.Inventory inventory) => new DA.Inventory
        {
            InventoryId = inventory.InventoryID,
            IngredientId = inventory.IngredientID,
            StoreId = inventory.StoreID,
            QtyRemaining = inventory.QtyRemaining
        };
        public static IEnumerable<Models.Inventory> ManMap(IEnumerable<DA.Inventory> inventory) => inventory.Select(ManMap);
        public static IEnumerable<DA.Inventory> ManMap(IEnumerable<Models.Inventory> inventory) => inventory.Select(ManMap);

        // All order detail mappings
        public static Models.OrderDetail ManMap(DA.OrderDetail orderDetail) => new Models.OrderDetail
        {
            OrderDetailID = orderDetail.OrderDetailId,
            OrderID = orderDetail.OrderId,
            ProductID = orderDetail.ProductId,
            QtyOrdered = orderDetail.QtyOrdered
        };
        public static DA.OrderDetail ManMap(Models.OrderDetail orderDetail) => new DA.OrderDetail
        {
            OrderDetailId = orderDetail.OrderDetailID,
            OrderId = orderDetail.OrderID,
            ProductId = orderDetail.ProductID,
            QtyOrdered = orderDetail.QtyOrdered
        };
        public static IEnumerable<Models.OrderDetail> ManMap(IEnumerable<DA.OrderDetail> orderDetail) => orderDetail.Select(ManMap);
        public static IEnumerable<DA.OrderDetail> ManMap(IEnumerable<Models.OrderDetail> orderDetail) => orderDetail.Select(ManMap);

        // All order header mappings
        public static Models.OrderHeader ManMap(DA.OrderHeader orderHeader) => new Models.OrderHeader
        {
            OrderID = orderHeader.OrderId,
            CustomerID = orderHeader.CustomerId,
            OrderDate = orderHeader.OrderDate,
            AddressID = orderHeader.AddressId,
            StoreID = orderHeader.StoreId,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active
        };
        public static DA.OrderHeader ManMap(Models.OrderHeader orderHeader) => new DA.OrderHeader
        {
            OrderId = orderHeader.OrderID,
            CustomerId = orderHeader.CustomerID,
            OrderDate = orderHeader.OrderDate,
            AddressId = orderHeader.AddressID,
            StoreId = orderHeader.StoreID,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active 
        };
        public static IEnumerable<Models.OrderHeader> ManMap(IEnumerable<DA.OrderHeader> orderHeader) => orderHeader.Select(ManMap);
        public static IEnumerable<DA.OrderHeader> ManMap(IEnumerable<Models.OrderHeader> orderHeader) => orderHeader.Select(ManMap);

        // All product mappings
        public static Models.Product ManMap(DA.Product product) => new Models.Product
        {
            ProductID = product.ProductId,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
        };
        public static DA.Product ManMap(Models.Product product) => new DA.Product
        {
            ProductId = product.ProductID,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
        };
        public static IEnumerable<Models.Product> ManMap(IEnumerable<DA.Product> product) => product.Select(ManMap);
        public static IEnumerable<DA.Product> ManMap(IEnumerable<Models.Product> product) => product.Select(ManMap);

        // All product recipe mappings
        public static Models.ProductRecipe ManMap(DA.ProductRecipe productRecipe) => new Models.ProductRecipe
        {
            ProductRecipeID = productRecipe.ProductRecipeId,
            IngredientID = productRecipe.IngredientId,
            ProductID = productRecipe.ProductId,
            IngredientQty = productRecipe.IngredientQty
        };
        public static DA.ProductRecipe ManMap(Models.ProductRecipe productRecipe) => new DA.ProductRecipe
        {
            ProductRecipeId = productRecipe.ProductRecipeID,
            IngredientId = productRecipe.IngredientID,
            ProductId = productRecipe.ProductID,
            IngredientQty = productRecipe.IngredientQty
        };
        public static IEnumerable<Models.ProductRecipe> ManMap(IEnumerable<DA.ProductRecipe> productRecipe) => productRecipe.Select(ManMap);
        public static IEnumerable<DA.ProductRecipe> ManMap(IEnumerable<Models.ProductRecipe> productRecipe) => productRecipe.Select(ManMap);

        // All store mappings
        public static Models.Store ManMap(DA.Store store) => new Models.Store
        {
            StoreID = store.StoreId,
            AddressLine1 = store.AddressLine1,
            AddressLine2 = store.AddressLine2,
            City = store.City,
            State = store.State,
            ZIP = store.Zip
        };
        public static DA.Store ManMap(Models.Store store) => new DA.Store
        {
            StoreId = store.StoreID,
            AddressLine1 = store.AddressLine1,
            AddressLine2 = store.AddressLine2,
            City = store.City,
            State = store.State,
            Zip = store.ZIP
        };
        public static IEnumerable<Models.Store> ManMap(IEnumerable<DA.Store> store) => store.Select(ManMap);
        public static IEnumerable<DA.Store> ManMap(IEnumerable<Models.Store> store) => store.Select(ManMap);
    }
}
