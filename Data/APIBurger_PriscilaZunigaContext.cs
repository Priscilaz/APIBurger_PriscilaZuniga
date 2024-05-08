using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIBurger_PriscilaZuniga.Data.Models;

namespace APIBurger_PriscilaZuniga.Data
{
    public class APIBurger_PriscilaZunigaContext : DbContext
    {
        public APIBurger_PriscilaZunigaContext (DbContextOptions<APIBurger_PriscilaZunigaContext> options)
            : base(options)
        {
        }

        public DbSet<APIBurger_PriscilaZuniga.Data.Models.Burger> Burger { get; set; } = default!;
    }
}
