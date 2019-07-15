using Microsoft.AspNetCore.Mvc;
using projetoDaniel.Data;
using projetoDaniel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Controllers
{
    public class ProductsController : Controller
    {


        private readonly ProjectTestDataContext _ctx = new ProjectTestDataContext();

        public IActionResult Index()
        {
            var model = _ctx.Products.ToList();
            return View(model);
        }
    }
}
