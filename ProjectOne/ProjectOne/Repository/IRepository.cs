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
        void DeleteCustomer(Models.Customer customer);

        void InsertAddress(Models.Address address);
        IEnumerable<Models.Address> GetAddresses();
        void UpdateAddress(Models.Address address);
        void DeleteAddress(Models.Address address);

        void InsertOrderHeader(Models.OrderHeader orderHeader);
        IEnumerable<Models.OrderHeader> GetOrderHeaders();
        void UpdateOrderHeader(Models.OrderHeader orderHeader);
        void DeleteOrderHeader(Models.OrderHeader orderHeader);

        void InsertOrderDetail(Models.OrderDetail orderDetail);
        IEnumerable<Models.OrderDetail> GetOrderDetails();
        void UpdateOrderDetail(Models.OrderDetail orderDetails);
        void DeleteOrderDetail(Models.OrderDetail orderDetails);

        void InsertProduct(Models.Product product);
        IEnumerable<Models.Product> GerProducts();
        void UpdateProduct(Models.Product product);
        void DeleteProduct(Models.Product product);

        void InsertProductRecipe(Models.ProductRecipe productRecipe);
        IEnumerable<Models.ProductRecipe> GetProducts();
        void UpdateProductRecipe(Models.ProductRecipe productRecipe);
        void DeleteProductRecipe(Models.ProductRecipe productRecipe);

        void InsertIngredient(Models.Ingredient ingredient);
        IEnumerable<Models.Ingredient> GetIngredients();
        void UpdateIngredient(Models.Ingredient ingredient);
        void DeleteIngredient(Models.Ingredient ingredient);

        void InsertInventory(Models.Inventory inventory);
        IEnumerable<Models.Inventory> GetInventories();
        void UpdateInventory(Models.Inventory inventory);
        void DeleteInventory(Models.Inventory inventory);

        void InsertStore(Models.Store store);
        IEnumerable<Models.Store> GetStores();
        void UpdateStore(Models.Store store);
        void DeleteStore(Models.Store store);





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
