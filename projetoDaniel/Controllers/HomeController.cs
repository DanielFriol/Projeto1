﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() =>  View();

        
    }
}
