using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JTweblista.Models;

namespace JTweblista.Data
{
    public class JTweblistaContext : DbContext
    {
        public JTweblistaContext (DbContextOptions<JTweblistaContext> options)
            : base(options)
        {
        }

        public DbSet<JTweblista.Models.Burger> Burger { get; set; } = default!;
    }
}
