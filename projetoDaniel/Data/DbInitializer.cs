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
                var products = new List<Buses>()
            {
                new Buses(){ Prefixo="4900",Empresa= "Mactur", Linha= 98, Quantidade_Lugares= 46},
                new Buses() { Prefixo="5300",Empresa= "Mactur", Linha= 98, Quantidade_Lugares= 47},
                new Buses() {Prefixo="4700",Empresa= "Mactur", Linha= 98, Quantidade_Lugares= 46},
                new Buses() {Prefixo="5000",Empresa= "Mactur", Linha= 98, Quantidade_Lugares= 47 },
                new Buses() {Prefixo="5400",Empresa= "Mactur", Linha= 98, Quantidade_Lugares= 47 }

            };

                ctx.Products.AddRange(products);
                ctx.SaveChanges();

            }

        }
    }
}
