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
    [Route("[controller]")]
    public class StoreController : Controller
    {
        public IRepository Repo { get; set; }

        public StoreController(IRepository repo)
        {
            Repo = repo;
        }


        [Route("Index")]
        public ActionResult Index()
        {
            IEnumerable<Models.Store> customers = ManualMapper.ManMap2(Repo.GetStores());
            return View(customers);
        }
    }
}

