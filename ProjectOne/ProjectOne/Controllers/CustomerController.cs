using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjectOne.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{
    public class CustomerController : Controller
    {
        public IRepository Repo { get; set; }

        public CustomerController(IRepository repo)
        {
            Repo = repo;
        }

        [Route("")]
        [Route("Index")]
        public ActionResult Index()
        {
            IEnumerable<Models.Customer> customers = ManualMapper.ManMap2(Repo.GetCustomers());
            return View(customers);
        }

        public string Sample(string id, string name)
        {
            return "Id = " + id + " Name= " + name;
        }

        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Customer newCustomer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Library.Customer newCustomerMapped = ManualMapper.ManMap2(newCustomer);
                    //var newCustomerMapped2 = ManualMapper.ManMap(newCustomerMapped);
                    Repo.InsertCustomer(newCustomerMapped);
                }
                else
                {
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("Id", ex.Message);
                return View();
            }
            catch
            {
                return View();
            }
        }

        [Route("Delete/{CustomerID}")]
        public ActionResult Delete(int id)
        {
            Library.Customer customer = Repo.GetCustomerByID(id);
            Models.Customer customerModel = ManualMapper.ManMap2(customer);
            return View(customerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [BindNever]IFormCollection collection)
        {
            try
            {
                // server-side checks for things like this
                // never assume only one client is working with your app at a time
                // (another browser might have deleted the record since we loaded the page)
                var success = Repo.DeleteCustomer(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
