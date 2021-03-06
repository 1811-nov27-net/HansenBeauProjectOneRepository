﻿using Microsoft.AspNetCore.Http;
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
    public class ProductController : Controller
    {
        public IRepository Repo { get; set; }

        public ProductController(IRepository repo)
        {
            Repo = repo;
        }

        [Route("Index")]
        public ActionResult Index()
        {
            IEnumerable<Models.Product> products = ManualMapper.ManMap2(Repo.GetProducts());
            return View(products);
        }
    }
}
