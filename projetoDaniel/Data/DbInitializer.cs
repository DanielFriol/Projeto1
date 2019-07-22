using projetoDaniel.Models;
using System.Collections.Generic;
using System.Linq;
using projetoDaniel.infra;

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
            var users = new List<User>()
            {
                new User(){Nome="admin", Email="admin@admin.com", Senha="1234".Encrypt(),TipoUsuario=1},
                new User(){Nome="Daniel", Email="danielfriol@gmail.com", Senha="4321".Encrypt(),TipoUsuario=0}

            };

            if (!ctx.Users.Any())
            {
                ctx.Users.AddRange(users);
                ctx.SaveChanges();

            }

            if (!ctx.Buses.Any())
            {
                ctx.Buses.AddRange(buses);
                ctx.SaveChanges();
            }

            if (!ctx.Avaliations.Any())
            {
                var avaliacao = new Avaliation() { Bus = buses[0], ArCond = 1, Balanco = 1, Barulho = 1, Conforto = 1, Space = 1, TemWifi = 0, User=users[1]};
                ctx.Avaliations.AddRange(avaliacao);
                ctx.SaveChanges();
            }


           
        }
    }
}
