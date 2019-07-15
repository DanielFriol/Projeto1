using projetoDaniel.Models;
using System.Collections.Generic;
using System.Linq;

namespace projetoDaniel.Data
{
    public class DbInitializer
    {
        public static void Init(ProjectTestDataContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Products.Any())
            {
                var products = new List<Products>()
            {
                new Products(){ Nome="Acucar", Preco= 5.99M, Quantidade = 25, Setor="Mantimentos" },
                new Products() { Nome = "Sabonete", Preco = 1.99M, Quantidade = 110, Setor="Higiene Pessoal"},
                new Products() {Nome = "Vassoura", Preco = 10.50M, Quantidade = 5,Setor= "Acessórios"},
                new Products() {Nome = "Picanha", Preco = 34.50M, Quantidade = 12, Setor = "Açougue" },
                new Products() {Nome = "Presunto", Preco = 4.5M, Quantidade = 1023, Setor = "Frios" }

            };

                ctx.Products.AddRange(products);
                ctx.SaveChanges();

            }

        }
    }
}
