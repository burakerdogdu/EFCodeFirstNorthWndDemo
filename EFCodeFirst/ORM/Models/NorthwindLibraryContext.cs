using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.ORM.Models
{
    public class NorthwindLibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WTRISTHDESK023\\SQLEXPRESS;Database=NORTHWINDDEMO;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Product> products { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
    }
}
