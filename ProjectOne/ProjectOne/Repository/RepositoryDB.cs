using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectOne.Models;
using DA = ProjectOne.DataAccess;
using ProjectOne;

namespace ProjectOne.Repository
{
    public class RepositoryDB : IRepository
    {
        private readonly DA.ItaDPizzaContext _db;

        public RepositoryDB(DA.ItaDPizzaContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));

            // Database first
        }

        /// <summary>
        /// likely useful to use GetByID method for these Delete methods
        /// </summary>
        /// <param name="Id"></param>
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
            return ManualMapper.ManMap(_db.Address);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return ManualMapper.ManMap(_db.Customer);
        }

        public IEnumerable<Customer> GetCustomers(int Id, params string[] names)
        {
            throw new NotImplementedException();
        }

        public void GetDetailsOfOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return ManualMapper.ManMap(_db.Ingredient);
        }

        public IEnumerable<Inventory> GetInventories()
        {
            return ManualMapper.ManMap(_db.Inventory);
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
            return ManualMapper.ManMap(_db.OrderDetail);
        }

        public IEnumerable<OrderHeader> GetOrderHeaders()
        {
            return ManualMapper.ManMap(_db.OrderHeader);
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
            return ManualMapper.ManMap(_db.ProductRecipe);
        }

        public IEnumerable<Product> GetProducts()
        {
            return ManualMapper.ManMap(_db.Product);
        }

        public IEnumerable<Product> GetProductsOfOrderByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> GetStores()
        {
            return ManualMapper.ManMap(_db.Store);
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
    }
}
