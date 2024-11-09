using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaioDeSol.Models;

namespace RaioDeSol.Data
{
    public class RaioContext : DbContext
    {
        public RaioContext (DbContextOptions<RaioContext> options)
            : base(options)
        {
        }

        public DbSet<RaioDeSol.Models.Escola> Escola { get; set; } = default!;
    }
}
