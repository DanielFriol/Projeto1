using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {

            var model = new List<Products>()
            {
                new Products(){ Nome="Acucar", Preco= 5.99M, Quantidade = 25, Setor="Mantimentos" },
                new Products() { Nome = "Sabonete", Preco = 1.99M, Quantidade = 110, Setor="Higiene Pessoal"},
                new Products() {Nome = "Vassoura", Preco = 10.50M, Quantidade = 5,Setor= "Acessórios"},
                new Products() {Nome = "Picanha", Preco = 34.50M, Quantidade = 12, Setor = "Açougue" },
                new Products() {Nome = "Presunto", Preco = 4.5M, Quantidade = 1023, Setor = "Frios" }

            };

            return View(model);

        }
    }
}
