using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreshShop.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshShop.Data
{
    public class FreshShopContext : DbContext
    {
        public FreshShopContext (DbContextOptions<FreshShopContext> options)
            : base(options)
        {
        }

        public DbSet<Vegetables> Vegetables { get; set; }

        public DbSet<Seeds> Seeds { get; set; }

        public DbSet<Fruits> Fruits { get; set; }
    }
}
