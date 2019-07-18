using Microsoft.AspNetCore.Mvc;
using projetoDaniel.Data;
using projetoDaniel.Models;
using System.Linq;

namespace projetoDaniel.Controllers
{
    public class BusesController : Controller
    {


        private readonly ProjectTestDataContext _ctx;

        public BusesController(ProjectTestDataContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var model = _ctx.Buses.ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddEdit()
        {


            return View();

        }

        [HttpPost]
        public IActionResult AddEdit(Buses model)
        {
            return RedirectToAction("Index");
            
        }
    }
}
