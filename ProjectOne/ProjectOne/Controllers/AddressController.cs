using Microsoft.AspNetCore.Mvc;
using ProjectOne.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{

    [Route("[controller]")]
    public class AddressController : Controller
    {
        public IRepository Repo { get; set; }

        public AddressController(IRepository repo)
        {
            Repo = repo;
        }

        [Route("Index")]
        public ActionResult Index()
        {
            IEnumerable<Library.Address> addresses = Repo.GetAddresses();
            var addressesModels = ManualMapper.ManMap2(addresses);
            return View(addressesModels);
        }
    }
}
