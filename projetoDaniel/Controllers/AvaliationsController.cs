using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Exchange.WebServices.Data;
using System.Security.Claims;
using projetoDaniel.Data;
using projetoDaniel.Models;
using System.Linq;
using WebMatrix.WebData;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace projetoDaniel.Controllers
{
    [Authorize]
    public class AvaliationsController : Controller
    {
        private readonly ProjectTestDataContext _ctx;
        private readonly UserManager<User> _userManager;
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

            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            AvaliationAddVM model = new AvaliationAddVM();
            model.UsuarioId = Convert.ToInt32(id);
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
