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
        public IActionResult AddEdit(int? id)
        {

            Buses model = new Buses();
            if (id != null)
            {

                model = _ctx.Buses.Find(id);
            }

            return View(model);

        }

        [HttpPost]
        public IActionResult AddEdit(Buses model)
        {
            if (ModelState.IsValid)
            {
                _ctx.Buses.Add(model);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}
