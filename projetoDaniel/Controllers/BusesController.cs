using Microsoft.AspNetCore.Mvc;
using projetoDaniel.Data;
using System.Linq;

namespace projetoDaniel.Controllers
{
    public class BusesController : Controller
    {


        private readonly ProjectTestDataContext _ctx = new ProjectTestDataContext();

        public IActionResult Index()
        {
            var model = _ctx.Products.ToList();
            return View(model);
        }
    }
}
