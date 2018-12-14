﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectOne.Models;
using DA = ProjectOne.DataAccess;
using ProjectOne;
using Microsoft.EntityFrameworkCore;

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
            var address = _db.Address.Include(a => a.OrderHeader).ThenInclude(oh => oh.OrderDetail).First(a => a.AddressId == Id);
            _db.Remove(address);
            foreach (var item in address.OrderHeader)
            {
                _db.Remove(item);
            }
            // figure this out
            //foreach (var item in oh.OrderDetail)
            //{
            //    _db.Remove(item);
            //}
            _db.SaveChanges();
        }

        // perhaps amend so that this method called DeleteOrderHeader method, cascading the deletion of order details as well
        public void DeleteCustomer(int Id)
        {
            var customer = _db.Customer.Where(c => c.CustomerId == Id).First();
            _db.Remove(customer);
            DeleteAddress(Id);
            DeleteOrderHeader(Id);
        }

        public void DeleteIngredient(int Id)
        {
            var ingredient = _db.Ingredient.Include(i => i.Inventory).Where(i => i.IngredientId == Id).First();
            _db.Remove(ingredient);
            foreach (var item in ingredient.Inventory)
            {
                _db.Remove(item);
            }
            _db.SaveChanges();
        }

        // Likely I will never use this because inventory entries will only be deleted when store entries are deleted or when ingredient entries are deleted
        public void DeleteInventory(int Id)
        {
            var inventory = _db.Address.Where(a => a.AddressId == Id).First();
            _db.Remove(inventory);
            _db.SaveChanges();
        }

        // Likely I will never use this because OrderDetail entries will only be deleted when order header entries are deleted or when product entries are deleted
        public void DeleteOrderDetail(int Id)
        {
            var orderDetail = _db.OrderDetail.Where(od => od.OrderDetailId == Id).First();
            _db.Remove(orderDetail);
            _db.SaveChanges();
        }


        public void DeleteOrderHeader(int Id)
        {
            var orderHeader = _db.OrderHeader.Where(oh => oh.OrderId == Id).First();
            _db.Remove(orderHeader);
            DeleteOrderDetail(Id);
            // this SaveChanges() method is not needed because DeleteOrderDetail(Id) would save the changes
            // _db.SaveChanges();
        }

        public void DeleteProduct(int Id)
        {
            var product = _db.Product.Where(p => p.ProductId == Id).First();
                _db.Remove(product);
            DeleteProductRecipe(Id);
            DeleteOrderDetail(Id);
        }

        public void DeleteProductRecipe(int Id)
        {
            var productRecipe = _db.ProductRecipe.Where(pr => pr.ProductRecipeId == Id).First();
            _db.Remove(productRecipe);
        }

        public void DeleteStore(int Id)
        {
            var store = _db.Store.Where(s => s.StoreId == Id).First();
            _db.Remove(store);
            DeleteInventory(Id);
            DeleteOrderHeader(Id);
        }



        public IEnumerable<Address> GetAddresses()
        {
            return ManualMapper.ManMap(_db.Address);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return ManualMapper.ManMap(_db.Customer);
        }

        public List<Models.OrderDetail> GetDetailsOfOrder(int id)
        {
            List<Models.OrderDetail> orderDetails = ManualMapper.ManMap(_db.OrderDetail.Where(od => od.OrderId == id)).ToList();
            return orderDetails;
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
            var orderHeader = ManualMapper.ManMap(_db.OrderHeader.OrderByDescending(or => or.OrderId).First());
            return orderHeader.OrderID;
        }

        public OrderHeader GetOrderByOrderId(int orderID)
        {
            return ManualMapper.ManMap(_db.OrderHeader.Where(o => o.OrderId == orderID).First());
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
            if (sortOrder.ToLower() == "e")
            {
                IEnumerable<OrderHeader> orderHistory = ManualMapper.ManMap(_db.OrderHeader);
                return orderHistory.OrderBy(o => o.OrderDate);
            }
            else if (sortOrder.ToLower() == "l")
            {
                IEnumerable<OrderHeader> orderHistory = ManualMapper.ManMap(_db.OrderHeader);
                return orderHistory.OrderByDescending(o => o.OrderDate);
            }
            else if (sortOrder.ToLower() == "c")
            {
                IEnumerable<OrderHeader> orderHistory = ManualMapper.ManMap(_db.OrderHeader);
                return orderHistory.OrderBy(o => o.TotalCost);
            }
            else if (sortOrder.ToLower() == "x")
            {
                IEnumerable<OrderHeader> orderHistory = ManualMapper.ManMap(_db.OrderHeader);
                return orderHistory.OrderByDescending(o => o.TotalCost);
            }
            else
            {
                // this is the same code a sfor the case "earliest"
                // I am using it as a default, and I will check for valid inputs in the 
                // ConsoleApp
                IEnumerable<OrderHeader> orderHistory = ManualMapper.ManMap(_db.OrderHeader);
                return orderHistory.OrderBy(o => o.OrderDate);
            };
        }

        public IEnumerable<OrderHeader> GetOrderHistoryAddress(int address)
        {
            IEnumerable<OrderHeader> orderCollection = ManualMapper.ManMap(_db.OrderHeader);
            return orderCollection.Where(o => o.AddressID == address);
        }

        public IEnumerable<OrderHeader> GetOrderHistoryCustomer(int user)
        {
            IEnumerable<OrderHeader> orderCollection = ManualMapper.ManMap(_db.OrderHeader);
            return orderCollection.OrderBy(o => o.OrderDate).Where(o => o.CustomerID == user);
        }

        public IEnumerable<OrderHeader> GetOrderHistoryStore(int store)
        {
            IEnumerable<OrderHeader> orderCollection = ManualMapper.ManMap(_db.OrderHeader);
            return orderCollection.Where(o => o.StoreID == store);
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
            List<DataAccess.OrderDetail> orderDetailInter = _db.OrderDetail.Where(o => o.OrderId == id).ToList();
            List<Product> orderProducts = new List<Product>();
            foreach (var item in orderDetailInter)
            {
                Product product = GetProductByID(item.ProductId);
                orderProducts.Add(product);
            }
            return orderProducts;
        }

        public IEnumerable<Store> GetStores()
        {
            return ManualMapper.ManMap(_db.Store);
        }

        public void InsertAddress(Address address)
        {
            _db.Add(ManualMapper.ManMap(address));
            _db.SaveChanges();
        }

        public void InsertCustomer(Customer customer)
        {
            _db.Customer.Include(c => c.OrderHeader);
            _db.Customer.Include(c => c.Address);
            _db.Add(ManualMapper.ManMap(customer));
            _db.SaveChanges();
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            _db.Ingredient.Include(i => i.Inventory);
            _db.Ingredient.Include(i => i.ProductRecipe);
            _db.Add(ManualMapper.ManMap(ingredient));
            _db.SaveChanges();
        }

        public void InsertInventory(Inventory inventory)
        {
            _db.Add(ManualMapper.ManMap(inventory));
            _db.SaveChanges();
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            _db.Add(ManualMapper.ManMap(orderDetail));
            _db.SaveChanges();
        }

        public void InsertOrderHeader(OrderHeader orderHeader)
        {
            _db.OrderHeader.Include(oh => oh.OrderDetail);
            _db.Add(ManualMapper.ManMap(orderHeader));
            _db.SaveChanges();
        }

        public void InsertProduct(Product product)
        {
            _db.Product.Include(p => p.OrderDetail);
            _db.Product.Include(p => p.ProductRecipe);
            _db.Add(ManualMapper.ManMap(product));
            _db.SaveChanges();
        }

        public void InsertProductRecipe(ProductRecipe productRecipe)
        {
            _db.Add(ManualMapper.ManMap(productRecipe));
            _db.SaveChanges();
        }

        public void InsertStore(Store store)
        {
            _db.Store.Include(s => s.Inventory);
            _db.Store.Include(s => s.OrderHeader);
            _db.Add(ManualMapper.ManMap(store));
            _db.SaveChanges();
        }

        public OrderHeader SuggestOrder()
        {
            OrderHeader orderSuggest = GetOrderHistory("l").FirstOrDefault();
            return orderSuggest;
        }

        public void UpdateAddress(Address address)
        {
            var dAAddress = ManualMapper.ManMap(address);
            _db.Update(dAAddress);
            _db.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var dACustomer = ManualMapper.ManMap(customer);
            _db.Update(dACustomer);
            _db.SaveChanges();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var dAIngredient = ManualMapper.ManMap(ingredient);
            _db.Update(dAIngredient);
            _db.SaveChanges();
        }

        public void UpdateInventory(Inventory inventory)
        {
            var dAInventory = ManualMapper.ManMap(inventory);
            _db.Update(dAInventory);
            _db.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetails)
        {
            var dAOrderDetails = ManualMapper.ManMap(orderDetails);
            _db.Update(dAOrderDetails);
            _db.SaveChanges();
        }

        public void UpdateOrderHeader(OrderHeader orderHeader)
        {
            var dAOrderHeader = ManualMapper.ManMap(orderHeader);
            _db.Update(dAOrderHeader);
            _db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var dAProduct = ManualMapper.ManMap(product);
            _db.Update(dAProduct);
            _db.SaveChanges();
        }

        public void UpdateProductRecipe(ProductRecipe productRecipe)
        {
            var dAProductRecipe = ManualMapper.ManMap(productRecipe);
            _db.Update(dAProductRecipe);
            _db.SaveChanges();
        }

        public void UpdateStore(Store store)
        {
            var dAStore = ManualMapper.ManMap(store);
            _db.Update(dAStore);
            _db.SaveChanges();
        }

        List<Customer> IRepository.GetCustomers(params string[] names)
        {
            List<DA.Customer> collectionDACustomers = new List<DA.Customer>();
            foreach (var item in names)
            {
                List<DA.Customer> customersToAdd = _db.Customer.Where(c => c.FirstName == item || c.LastName == item).ToList();
                foreach (var unit in customersToAdd)
                {
                    if (!collectionDACustomers.Contains(unit))
                    {
                        collectionDACustomers.Add(unit);
                    }
                }
            }
            List<Models.Customer> collectionModelCustomers = ManualMapper.ManMap(collectionDACustomers);
            return collectionModelCustomers;
        }
        //for some reason, it wants me to explicitly write IRepository.GetProductById() for
        // this method... IDK why...
        Product GetProductByID(int productId)
        {
            IEnumerable<Product> productCollection = ManualMapper.ManMap(_db.Product);
            return productCollection.Where(p => p.ProductID == productId).First();
        }
    }
}