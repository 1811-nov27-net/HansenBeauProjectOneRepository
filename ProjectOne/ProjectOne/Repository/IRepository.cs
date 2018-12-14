using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Repository
{
    public interface IRepository
    {
        // CRUD methods
        void InsertCustomer(Models.Customer customer);
        IEnumerable<Models.Customer> GetCustomers();
        void UpdateCustomer(Models.Customer customer);
        void DeleteCustomer(int Id);

        void InsertAddress(Models.Address address);
        IEnumerable<Models.Address> GetAddresses();
        void UpdateAddress(Models.Address address);
        void DeleteAddress(int Id);

        void InsertOrderHeader(Models.OrderHeader orderHeader);
        IEnumerable<Models.OrderHeader> GetOrderHeaders();
        void UpdateOrderHeader(Models.OrderHeader orderHeader);
        void DeleteOrderHeader(int Id);

        void InsertOrderDetail(Models.OrderDetail orderDetail);
        IEnumerable<Models.OrderDetail> GetOrderDetails();
        void UpdateOrderDetail(Models.OrderDetail orderDetails);
        void DeleteOrderDetail(int Id);

        void InsertProduct(Models.Product product);
        IEnumerable<Models.Product> GetProducts();
        void UpdateProduct(Models.Product product);
        void DeleteProduct(int Id);

        void InsertProductRecipe(Models.ProductRecipe productRecipe);
        IEnumerable<Models.ProductRecipe> GetProductRecipes();
        void UpdateProductRecipe(Models.ProductRecipe productRecipe);
        void DeleteProductRecipe(int Id);

        void InsertIngredient(Models.Ingredient ingredient);
        IEnumerable<Models.Ingredient> GetIngredients();
        void UpdateIngredient(Models.Ingredient ingredient);
        void DeleteIngredient(int Id);

        void InsertInventory(Models.Inventory inventory);
        IEnumerable<Models.Inventory> GetInventories();
        void UpdateInventory(Models.Inventory inventory);
        void DeleteInventory(int Id);

        void InsertStore(Models.Store store);
        IEnumerable<Models.Store> GetStores();
        void UpdateStore(Models.Store store);
        void DeleteStore(int Id);

        // Functionality Methods
        // Customer
        List<Models.Customer> GetCustomers(params string[] names);

        // Address

        // OrderHeader
        Models.OrderHeader SuggestOrder();
        IEnumerable<Models.Product> GetProductsOfOrderByID(int id);
        Models.OrderHeader GetOrderByOrderId(int orderID);
        IEnumerable<Models.OrderHeader> GetOrderHistoryAddress(int address);
        IEnumerable<Models.OrderHeader> GetOrderHistoryCustomer(int user);
        IEnumerable<Models.OrderHeader> GetOrderHistoryStore(int store);
        IEnumerable<Models.OrderHeader> GetOrderHistory(string sortOrder);
        int GetLastOrderOfCustomer(int id);

        // OrderDetail

        // Product
        Models.Product GetProductByID(int productId);

        // ProductRecipe

        // Ingredient

        // Inventory

        // Store



        //void InsertOrder(Order order);
        //void DeleteOrder(int orderID);
        //void UpdateOrder(Order order);
        //IEnumerable<Product> GetProductsOfOrderByID(int OrderID);
        //IEnumerable<Order> GetOrders();
        //Order GetOrderByOrderId(int orderID);
        //void DisplayOrderDetailsByOrderID(int orderID);
        //IEnumerable<Order> DisplayOrderHistoryAddress(int address);
        //IEnumerable<Order> DisplayOrderHistoryUser(int user);
        //IEnumerable<Order> DisplayOrderHistoryStore(int store);
        //IEnumerable<Order> DisplayOrderHistory(string sortOrder);
        //int getLastId();
        //void Save();
    }
}
