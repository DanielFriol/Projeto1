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


            var buses = new List<Buses>()
            {
                new Buses(){ Prefixo="4900",Empresa= "Mactur", Linha= 98, Quantidadelugares= 46},
                new Buses() { Prefixo="5300",Empresa= "Mactur", Linha= 98, Quantidadelugares= 47},
                new Buses() {Prefixo="4700",Empresa= "Mactur", Linha= 98, Quantidadelugares= 46},
                new Buses() {Prefixo="5000",Empresa= "Mactur", Linha= 98, Quantidadelugares= 47 },
                new Buses() {Prefixo="5400",Empresa= "Mactur", Linha= 98, Quantidadelugares= 47 }

            };

            if (!ctx.Buses.Any())
            {
                ctx.Buses.AddRange(buses);
                ctx.SaveChanges();
            }

            if (!ctx.Avaliations.Any())
            {
                var avaliacao = new Avaliation() { Bus = buses[0], ArCond = 1, Balanco = 1, Barulho = 1, Conforto = 1, Space = 1, TemWifi = 0 };
                ctx.Avaliations.AddRange(avaliacao);
                ctx.SaveChanges();
            }
        }
    }
}
