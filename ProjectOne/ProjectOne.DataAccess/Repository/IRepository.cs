using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOne.Library;

namespace ProjectOne.Repository
{
    public interface IRepository
    {
        // CRUD methods
        void InsertCustomer(Library.Customer customer);
        IEnumerable<Library.Customer> GetCustomers();
        void UpdateCustomer(Library.Customer customer);
        bool DeleteCustomer(int Id);
        bool VerifyCustomer(string firstname, string lastname, string password);
        Customer SearchCustomerByNameandPassword(string firstname, string lastname, string password);

        void InsertAddress(Library.Address address);
        IEnumerable<Library.Address> GetAddresses();
        void UpdateAddress(Library.Address address);
        void DeleteAddress(int Id);
        IEnumerable<string> GetAddressNames();

        bool InsertOrderHeader(Library.OrderHeader orderHeader);
        IEnumerable<Library.OrderHeader> GetOrderHeaders();
        void UpdateOrderHeader(Library.OrderHeader orderHeader);
        void DeleteOrderHeader(int Id);

        void InsertOrderDetail(Library.OrderDetail orderDetail);
        IEnumerable<Library.OrderDetail> GetOrderDetails();
        List<Library.OrderDetail> GetOrderDetailByOrderHeaderID(int orderHeaderId);
        void UpdateOrderDetail(Library.OrderDetail orderDetails);
        void DeleteOrderDetail(int Id);

        void InsertProduct(Library.Product product);
        IEnumerable<Library.Product> GetProducts();
        void UpdateProduct(Library.Product product);
        void DeleteProduct(int Id);
        IEnumerable<string> GetProductNames();

        void InsertProductRecipe(Library.ProductRecipe productRecipe);
        IEnumerable<Library.ProductRecipe> GetProductRecipes();
        void UpdateProductRecipe(Library.ProductRecipe productRecipe);
        void DeleteProductRecipe(int Id);

        void InsertIngredient(Library.Ingredient ingredient);
        IEnumerable<Library.Ingredient> GetIngredients();
        void UpdateIngredient(Library.Ingredient ingredient);
        void DeleteIngredient(int Id);

        void InsertInventory(Library.Inventory inventory);
        Customer GetCustomerByID(int customerID);
        IEnumerable<Library.Inventory> GetInventories();
        void UpdateInventory(Library.Inventory inventory);
        void DeleteInventory(int Id);

        void InsertStore(Library.Store store);
        IEnumerable<Library.Store> GetStores();
        void UpdateStore(Library.Store store);
        void DeleteStore(int Id);
        string GetStoreName(int orderID);

        // Functionality Methods
        // Customer
        List<Library.Customer> GetCustomers(params string[] names);

        // Address

        // OrderHeader
        Library.OrderHeader SuggestOrder(int customerId);
        IEnumerable<Library.Product> GetProductsOfOrderByID(int id);
        Library.OrderHeader GetOrderByOrderId(int orderID);
        IEnumerable<Library.OrderHeader> GetOrderHistoryAddress(int address);
        IEnumerable<Library.OrderHeader> GetOrderHistoryCustomer(int user);
        IEnumerable<Library.OrderHeader> GetOrderHistoryStore(int store);
        IEnumerable<Library.OrderHeader> GetOrderHistory(int sortOrder);
        int GetLastOrderOfCustomer(int id);

        // OrderDetail

        // Product
        Library.Product GetProductByID(int productId);

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
