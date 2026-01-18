using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using S2T1.Models;

namespace S2T1.Data
{
    public class S2T1Context : DbContext
    {
        public S2T1Context (DbContextOptions<S2T1Context> options)
            : base(options)
        {
        }

        public DbSet<S2T1.Models.Cliente> Cliente { get; set; } = default!;
    }
}
