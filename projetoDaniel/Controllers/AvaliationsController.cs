using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projetoDaniel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Controllers
{
    [Authorize]
    public class AvaliationsController:Controller
    {
        private ProjectTestDataContext db = new ProjectTestDataContext();
        private readonly ProjectTestDataContext _ctx;

        public AvaliationsController(ProjectTestDataContext ctx)
        {
            _ctx = ctx;

        }

        public IActionResult Index()
        {

            var model = _ctx.Avaliations.ToList();
            return View(model); 
        }

       

    }
}
