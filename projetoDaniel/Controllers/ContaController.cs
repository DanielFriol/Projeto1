using Microsoft.AspNetCore.Mvc;
using projetoDaniel.Data;
using projetoDaniel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoDaniel.infra;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace projetoDaniel.Controllers
{
    public class ContaController:Controller
    {
        private readonly ProjectTestDataContext _ctx;

        public ContaController(ProjectTestDataContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Login(string returnUrl) => View(new LoginVM { ReturnUrl = returnUrl });
            
        [HttpPost]
        public async Task<IActionResult> Login (LoginVM model)
        {

            var usuario = _ctx.Users.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower()) ;
            if (usuario == null)
            {
                ModelState.AddModelError("Email", "Email não localizado");

            }
            else
            {
                if(usuario.Senha != model.Senha.Encrypt())
                {
                    ModelState.AddModelError("Senha", "Senha inválida");
                }

                if (ModelState.IsValid)
                {
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Email, usuario.Email));
                    identity.AddClaim(new Claim(ClaimTypes.Name, usuario.Nome));
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(
                     CookieAuthenticationDefaults.AuthenticationScheme,
                     principal,
                     new AuthenticationProperties()
                     {
                         IsPersistent = model.Lembrar
                     }
                        );

                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&  Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);


                    }
                    return RedirectToAction("Index", "Buses");
                }

                
            }
            return View(model);

        }

        public async Task<IActionResult> logOut()
        {


            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Login");
        }
    }
}
