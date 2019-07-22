using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class AvaliationsController : Controller
    {
        private readonly ProjectTestDataContext _ctx;

        public AvaliationsController(ProjectTestDataContext ctx)
        {
            _ctx = ctx;

        }




        public IActionResult Index()
        {

            AvaliationsIndexVM viewModel = new AvaliationsIndexVM
            {

                Buses = _ctx.Buses.ToList(),
                Avaliation = _ctx.Avaliations.ToList(),
            };


            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddAvaliation()
        {


            AvaliationAddVM model = new AvaliationAddVM();
            return View(model);

        }

        [HttpPost]
        public IActionResult AddAvaliation(Avaliation model)
        {
            if (ModelState.IsValid)
            {
                _ctx.Avaliations.Add(model);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);




        }

    }
}
