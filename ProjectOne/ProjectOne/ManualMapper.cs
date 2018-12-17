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
        public static Library.Address ManMap(DA.Address address) => new Library.Address
        {
            AddressId = address.AddressId,
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            State = address.State,
            ZIP = address.Zip,
            CustomerID = address.CustomerId
        };
        public static DA.Address ManMap(Library.Address address) => new DA.Address
        {
            AddressId = address.AddressId,
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            State = address.State,
            Zip = address.ZIP,
            CustomerId = address.CustomerID
        };
        public static IEnumerable<Library.Address> ManMap(IEnumerable<DA.Address> address) => address.Select(ManMap);
        public static IEnumerable<DA.Address> ManMap(IEnumerable<Library.Address> address) => address.Select(ManMap);

        // All customer mappings
        // DataAccess to/from Library
        public static Library.Customer ManMap(DA.Customer customer) => new Library.Customer
        {
            CustomerID = customer.CustomerId,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DefaultAddressId = customer.DefaultAddressId,
            CustomerPassword = customer.CustomerPassword
        };
        public static DA.Customer ManMap(Library.Customer customer) => new DA.Customer
        {
            CustomerId = customer.CustomerID,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            DefaultAddressId = customer.DefaultAddressId,
            CustomerPassword = customer.CustomerPassword
        };
        public static IEnumerable<Library.Customer> ManMap(IEnumerable<DA.Customer> customer) => customer.Select(ManMap);
        public static IEnumerable<DA.Customer> ManMap(IEnumerable<Library.Customer> customer) => customer.Select(ManMap);
        //List-to-List mappings included to help with RepositoryDB.GetCustomers(params string[] names) method
        public static List<Library.Customer> ManMap(List<DA.Customer> customer) => customer.Select(ManMap).ToList();
        public static List<DA.Customer> ManMap(List<Library.Customer> customer) => customer.Select(ManMap).ToList();
        // Library to/from Models
        public static Models.Customer ManMap2(Library.Customer customer) => new Models.Customer
        {
            CustomerID = customer.CustomerID,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            CustomerPassword = customer.CustomerPassword
        };
        public static Library.Customer ManMap2(Models.Customer customer) => new Library.Customer
        {
            CustomerID = customer.CustomerID,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            CustomerPassword = customer.CustomerPassword
        };
        // 
        public static IEnumerable<Library.Customer> ManMap2(IEnumerable<Models.Customer> customer) => customer.Select(ManMap2);
        public static IEnumerable<Models.Customer> ManMap2(IEnumerable<Library.Customer> customer) => customer.Select(ManMap2);


        // All ingredient mappings
        public static Library.Ingredient ManMap(DA.Ingredient ingredient) => new Library.Ingredient
        {
            IngredientID = ingredient.IngredientId,
            IngredientName = ingredient.IngredientName,
            IngredientPrice = ingredient.IngredientPrice
        };
        public static DA.Ingredient ManMap(Library.Ingredient ingredient) => new DA.Ingredient
        {
            IngredientId = ingredient.IngredientID,
            IngredientName = ingredient.IngredientName,
            IngredientPrice = ingredient.IngredientPrice
        };
        public static IEnumerable<Library.Ingredient> ManMap(IEnumerable<DA.Ingredient> ingredient) => ingredient.Select(ManMap);
        public static IEnumerable<DA.Ingredient> ManMap(IEnumerable<Library.Ingredient> ingredient) => ingredient.Select(ManMap);

        // All inventory mappings
        public static Library.Inventory ManMap(DA.Inventory inventory) => new Library.Inventory
        {
            InventoryID = inventory.InventoryId,
            IngredientID = inventory.IngredientId,
            StoreID = inventory.StoreId,
            QtyRemaining = inventory.QtyRemaining
        };
        public static DA.Inventory ManMap(Library.Inventory inventory) => new DA.Inventory
        {
            InventoryId = inventory.InventoryID,
            IngredientId = inventory.IngredientID,
            StoreId = inventory.StoreID,
            QtyRemaining = inventory.QtyRemaining
        };
        public static IEnumerable<Library.Inventory> ManMap(IEnumerable<DA.Inventory> inventory) => inventory.Select(ManMap);
        public static IEnumerable<DA.Inventory> ManMap(IEnumerable<Library.Inventory> inventory) => inventory.Select(ManMap);

        // All order detail mappings
        public static Library.OrderDetail ManMap(DA.OrderDetail orderDetail) => new Library.OrderDetail
        {
            OrderDetailID = orderDetail.OrderDetailId,
            OrderID = orderDetail.OrderId,
            ProductID = orderDetail.ProductId,
            QtyOrdered = orderDetail.QtyOrdered
        };
        public static DA.OrderDetail ManMap(Library.OrderDetail orderDetail) => new DA.OrderDetail
        {
            OrderDetailId = orderDetail.OrderDetailID,
            OrderId = orderDetail.OrderID,
            ProductId = orderDetail.ProductID,
            QtyOrdered = orderDetail.QtyOrdered
        };
        public static IEnumerable<Library.OrderDetail> ManMap(IEnumerable<DA.OrderDetail> orderDetail) => orderDetail.Select(ManMap);
        public static IEnumerable<DA.OrderDetail> ManMap(IEnumerable<Library.OrderDetail> orderDetail) => orderDetail.Select(ManMap);

        // All order header mappings
        public static Library.OrderHeader ManMap(DA.OrderHeader orderHeader) => new Library.OrderHeader
        {
            OrderID = orderHeader.OrderId,
            CustomerID = orderHeader.CustomerId,
            OrderDate = orderHeader.OrderDate,
            AddressID = orderHeader.AddressId,
            StoreID = orderHeader.StoreId,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active
        };
        public static DA.OrderHeader ManMap(Library.OrderHeader orderHeader) => new DA.OrderHeader
        {
            OrderId = orderHeader.OrderID,
            CustomerId = orderHeader.CustomerID,
            OrderDate = orderHeader.OrderDate,
            AddressId = orderHeader.AddressID,
            StoreId = orderHeader.StoreID,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active 
        };
        public static Library.OrderHeader ManMap2(Models.OrderHeader orderHeader) => new Library.OrderHeader
        {
            OrderID = orderHeader.OrderID,
            CustomerID = orderHeader.CustomerID,
            OrderDate = orderHeader.OrderDate,
            AddressID = orderHeader.AddressID,
            StoreID = orderHeader.StoreID,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active
        };
        public static Models.OrderHeader ManMap2(Library.OrderHeader orderHeader) => new Models.OrderHeader
        {
            OrderID = orderHeader.OrderID,
            CustomerID = orderHeader.CustomerID,
            OrderDate = orderHeader.OrderDate,
            AddressID = orderHeader.AddressID,
            StoreID = orderHeader.StoreID,
            TotalCost = orderHeader.TotalCost,
            Active = orderHeader.Active
        };
        public static IEnumerable<Library.OrderHeader> ManMap(IEnumerable<DA.OrderHeader> orderHeader) => orderHeader.Select(ManMap);
        public static IEnumerable<DA.OrderHeader> ManMap(IEnumerable<Library.OrderHeader> orderHeader) => orderHeader.Select(ManMap);
        public static IEnumerable<Library.OrderHeader> ManMap2(IEnumerable<Models.OrderHeader> orderHeader) => orderHeader.Select(ManMap2);
        public static IEnumerable<Models.OrderHeader> ManMap2(IEnumerable<Library.OrderHeader> orderHeader) => orderHeader.Select(ManMap2);

        // All product mappings
        public static Library.Product ManMap(DA.Product product) => new Library.Product
        {
            ProductID = product.ProductId,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
        };
        public static DA.Product ManMap(Library.Product product) => new DA.Product
        {
            ProductId = product.ProductID,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
        };
        public static IEnumerable<Library.Product> ManMap(IEnumerable<DA.Product> product) => product.Select(ManMap);
        public static IEnumerable<DA.Product> ManMap(IEnumerable<Library.Product> product) => product.Select(ManMap);

        // All product recipe mappings
        public static Library.ProductRecipe ManMap(DA.ProductRecipe productRecipe) => new Library.ProductRecipe
        {
            ProductRecipeID = productRecipe.ProductRecipeId,
            IngredientID = productRecipe.IngredientId,
            ProductID = productRecipe.ProductId,
            IngredientQty = productRecipe.IngredientQty
        };
        public static DA.ProductRecipe ManMap(Library.ProductRecipe productRecipe) => new DA.ProductRecipe
        {
            ProductRecipeId = productRecipe.ProductRecipeID,
            IngredientId = productRecipe.IngredientID,
            ProductId = productRecipe.ProductID,
            IngredientQty = productRecipe.IngredientQty
        };
        public static IEnumerable<Library.ProductRecipe> ManMap(IEnumerable<DA.ProductRecipe> productRecipe) => productRecipe.Select(ManMap);
        public static IEnumerable<DA.ProductRecipe> ManMap(IEnumerable<Library.ProductRecipe> productRecipe) => productRecipe.Select(ManMap);

        // All store mappings
        public static Library.Store ManMap(DA.Store store) => new Library.Store
        {
            StoreID = store.StoreId,
            AddressLine1 = store.AddressLine1,
            AddressLine2 = store.AddressLine2,
            City = store.City,
            State = store.State,
            ZIP = store.Zip
        };
        public static DA.Store ManMap(Library.Store store) => new DA.Store
        {
            StoreId = store.StoreID,
            AddressLine1 = store.AddressLine1,
            AddressLine2 = store.AddressLine2,
            City = store.City,
            State = store.State,
            Zip = store.ZIP
        };
        public static IEnumerable<Library.Store> ManMap(IEnumerable<DA.Store> store) => store.Select(ManMap);
        public static IEnumerable<DA.Store> ManMap(IEnumerable<Library.Store> store) => store.Select(ManMap);
    }
}
