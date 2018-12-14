using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOne.Models;

namespace ProjectOne.Repository
{
    public class Repository : IRepository
    {
        public void DeleteAddress(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteInventory(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderDetail(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderHeader(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductRecipe(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStore(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void GetDetailsOfOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> GetInventories()
        {
            throw new NotImplementedException();
        }

        public int GetLastOrderOfCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public OrderHeader GetOrderByOrderId(int orderID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetOrderHeaders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetOrderHistory(string sortOrder)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetOrderHistoryAddress(int address)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetOrderHistoryCustomer(int user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderHeader> GetOrderHistoryStore(int store)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<ProductRecipe> GetProductRecipes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsOfOrderByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> GetStores()
        {
            throw new NotImplementedException();
        }

        public void InsertAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void InsertInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }

        public void InsertOrderHeader(OrderHeader orderHeader)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertProductRecipe(ProductRecipe productRecipe)
        {
            throw new NotImplementedException();
        }

        public void InsertStore(Store store)
        {
            throw new NotImplementedException();
        }

        public OrderHeader SuggestOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetail(OrderDetail orderDetails)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderHeader(OrderHeader orderHeader)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductRecipe(ProductRecipe productRecipe)
        {
            throw new NotImplementedException();
        }

        public void UpdateStore(Store store)
        {
            throw new NotImplementedException();
        }

        List<Customer> IRepository.GetCustomers(params string[] names)
        {
            throw new NotImplementedException();
        }

        Product IRepository.GetProductByID(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
