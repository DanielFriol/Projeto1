using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projetoDaniel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDaniel.Data
{
    public class ProjectTestDataContext : DbContext
    {
        private readonly IConfiguration _config;

        public ProjectTestDataContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("projectConnection"));
        }

        public DbSet<Buses> Buses { get; set; }
        public DbSet<Avaliation> Avaliations { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
