using Microsoft.AspNetCore.Mvc;
using ProjectOne.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{
    public class OrderHeaderController
    {
        public IRepository Repo { get; set; }

        public OrderHeaderController(IRepository repo)
        {
            Repo = repo;
        }

        //[Route("")]
        //[Route("Index")]
        //public ActionResult SignIn(string firstName, string lastName)
        //{
        //    Models.Customer currentCustomer = ManualMapper.ManMap2(Repo.GetCustomers(firstName, lastName).FirstOrDefault());
        //    return View(currentCustomer);
        //}
    }
}
