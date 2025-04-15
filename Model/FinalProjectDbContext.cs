using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model
{
    public class FinalProjectDbContext:DbContext
    {
        public FinalProjectDbContext(DbContextOptions options) : base(options) 
        {
        }

        public FinalProjectDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:"Data Source =.; Initial Catalog = FinalProject; Integrated Security = True; TrustServerCertificate=True;");
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
