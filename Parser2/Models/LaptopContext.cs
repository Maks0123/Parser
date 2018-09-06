using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parser2.Models
{
    public class LaptopContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; }
        

        public LaptopContext(DbContextOptions<LaptopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
