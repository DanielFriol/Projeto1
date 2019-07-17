using Microsoft.EntityFrameworkCore;
using projetoDaniel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Data
{
    public class ProjectTestDataContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TFU4NF7\SQLEXPRESS02;Initial Catalog=ProjetoDaniel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Buses> Products { get; set; }
    }
}
