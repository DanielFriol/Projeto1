using Microsoft.AspNetCore.Mvc;
using System;

namespace projetoDaniel.Controllers
{
    public class TesteController : Controller
    {
        public string Server()
        {

            return $"Bateu no teste controller - {DateTime.Now}";

        }

    }
}
