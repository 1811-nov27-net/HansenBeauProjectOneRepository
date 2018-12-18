using Microsoft.AspNetCore.Mvc;
using ProjectOne.Repository;
using System;
using System.Collections.Generic;
using DA = ProjectOne.DataAccess;
using System.Linq;
using System.Threading.Tasks;
using ProjectOne.Library;

namespace ProjectOne.Controllers
{
    [Route("[controller]")]
    public class OrderHeaderController : Controller
    {
        public IRepository Repo { get; set; }

        public OrderHeaderController(IRepository repo)
        {
            Repo = repo;
        }

        [Route("Index")]
        public ActionResult Index([FromForm]string firstName, [FromForm]string lastName, [FromForm]string password, [FromForm]string confirmpassword)
        {
            if (confirmpassword == null)
            {
                bool exists = Repo.VerifyCustomer(firstName, lastName, password);
                {
                    if (exists == true)
                    {
                        Library.Customer customer = Repo.SearchCustomerByNameandPassword(firstName, lastName, password);
                        IEnumerable<Library.OrderHeader> orderHeaderList = Repo.GetOrderHistoryCustomer(customer.CustomerID);
                        IEnumerable<Models.OrderHeader> orderHeaderModelsList = ManualMapper.ManMap2(orderHeaderList);
                        return View(orderHeaderModelsList);
                    }
                    else
                    {
                        return RedirectToAction();
                    }
                }
            }
            else
            {
                if (confirmpassword == password)
                {
                    Customer customerToInsert = new Library.Customer();
                    customerToInsert.FirstName = firstName;
                    customerToInsert.LastName = lastName;
                    customerToInsert.CustomerPassword = password;
                    Repo.InsertCustomer(customerToInsert);

                    Library.Customer customer = Repo.SearchCustomerByNameandPassword(firstName, lastName, password);
                    IEnumerable<Library.OrderHeader> orderHeaderList = Repo.GetOrderHistoryCustomer(customer.CustomerID);
                    IEnumerable<Models.OrderHeader> orderHeaderModelsList = ManualMapper.ManMap2(orderHeaderList);
                    return View(orderHeaderModelsList);
                }
                else
                {
                    return RedirectToAction();
                }
            }
            
        }

        [Route("Resubmit")]
        // here, id is "OrderId"
        public ActionResult Resubmit(int id)
        {
            OrderHeader orderHeader = Repo.GetOrderByOrderId(id);
            orderHeader.OrderID = 0;
            orderHeader.OrderDate = DateTime.Now;
            Repo.InsertOrderHeader(orderHeader);

            IEnumerable<OrderHeader> orderHeaderList1 = Repo.GetOrderHistory(1);
            IEnumerable<Models.OrderHeader> orderHeaderList11 = ManualMapper.ManMap2(orderHeaderList1);

            return View("OrderHistory", orderHeaderList11);

        }

        
        public ActionResult OrderHistory(int sort)
        {
            switch (sort)
            {
                case 1:
                    {
                        IEnumerable<OrderHeader> orderHeaderList1 = Repo.GetOrderHistory(1);
                        var orderHeaderList11 = ManualMapper.ManMap2(orderHeaderList1);
                        return View(orderHeaderList11);
                    }
                case 2:
                    {
                        IEnumerable<OrderHeader> orderHeaderList2 = Repo.GetOrderHistory(2);
                            var orderHeaderList21 = ManualMapper.ManMap2(orderHeaderList2);
                        return View(orderHeaderList21);
                    }
                case 3:
                    {
                        IEnumerable<OrderHeader> orderHeaderList3 = Repo.GetOrderHistory(3);
                            var orderHeaderList31 = ManualMapper.ManMap2(orderHeaderList3);
                        return View(orderHeaderList31);
                    }
                case 4:
                    {
                        IEnumerable<OrderHeader> orderHeaderList4 = Repo.GetOrderHistory(4);
                        var orderHeaderList41 = ManualMapper.ManMap2(orderHeaderList4);
                        return View(orderHeaderList41);
                    }
                default:
                    IEnumerable<OrderHeader> orderHeaderList = Repo.GetOrderHistory(1);
                    var orderHeaderList111 = ManualMapper.ManMap2(orderHeaderList);
                    return View(orderHeaderList111);
            }


            
        }

        [Route("CreateNew")]
        public ActionResult CreateNew(int id)
        {
            Product productToOrder = Repo.GetProductByID(id);
            Library.OrderHeader orderHeader = new Library.OrderHeader();
            orderHeader.OrderDate = DateTime.Now;
            orderHeader.CustomerID = 1;
            orderHeader.AddressID = 1;
            orderHeader.StoreID = 1;
            orderHeader.TotalCost = productToOrder.UnitPrice;
            Repo.InsertOrderHeader(orderHeader);

            IEnumerable<OrderHeader> orderHeaderList1 = Repo.GetOrderHistory(1);
            IEnumerable<Models.OrderHeader> orderHeaderList11 = ManualMapper.ManMap2(orderHeaderList1);

            return View("OrderHistory", orderHeaderList11);
        }

        //public ActionResult Details()
        //{
        //    Models.OrderHeader orderHeader = new Models.OrderHeader();
        //    return View();
        //}

        //[Route("Resubmit")]
        //public ActionResult Resubmit(int id)
        //{
        //    OrderHeader orderHeader = Repo.GetOrderByOrderId(id);
        //    List<OrderDetail> orderDetailstoAdd = Repo.GetOrderDetailByOrderHeaderID(id);
        //    foreach (var item in orderDetailstoAdd)
        //    {
        //        orderHeader.OrderDetail.Add(item);
        //    }
        //    orderHeader.OrderID = 0;
        //    orderHeader.OrderDate = DateTime.Now;
        //    Repo.InsertOrderHeader(orderHeader);
        //    return View(nameof(Index));
        //}

        [Route("NewOrder")]
        public ActionResult NewOrder()
        {
            return View();
        }

        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }



        //[HttpPost("CreateNew/{AddressID}")]
        //[ValidateAntiForgeryToken]
        //public ActionResult CreateNew(int AddressID)
        //{
        //    var orderHeader = new Models.OrderHeader();
        //    orderHeader.AddressID = AddressID;
        //    return View(orderHeader);
        //}


        //public ActionResult Index(Models.Customer cus)
        //{
        //    return View(cus);
        //}

        //[Route("Index")]
        //public ActionResult Index2(string firstName, string lastName, string password)
        //{
        //    bool exists = Repo.VerifyCustomer(firstName, lastName, password);
        //    {
        //        if (exists == true)
        //        {
        //            Library.Customer customer = Repo.SearchCustomerByNameandPassword(firstName, lastName, password);
        //            IEnumerable<Library.OrderHeader> orderHeaderList = Repo.GetOrderHistoryCustomer(customer.CustomerID);
        //            IEnumerable<Models.OrderHeader> orderHeaderModelsList = ManualMapper.ManMap2(orderHeaderList);
        //            return View(orderHeaderModelsList);
        //        }
        //        else
        //        {
        //            return RedirectToAction();
        //        }
        //    }
        //}

        //[Route("")]
        //[Route("Index")]
        //public ActionResult SignIn(string firstName, string lastName)
        //{
        //    Models.Customer currentCustomer = ManualMapper.ManMap2(Repo.GetCustomers(firstName, lastName).FirstOrDefault());
        //    return View(currentCustomer);
        //}
    }
}
