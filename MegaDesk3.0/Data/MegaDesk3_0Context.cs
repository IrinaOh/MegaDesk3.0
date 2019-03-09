using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk3._0.Models
{
    public class MegaDesk3_0Context : DbContext
    {
        public MegaDesk3_0Context (DbContextOptions<MegaDesk3_0Context> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk3._0.Models.Quote> Quote { get; set; }
    }
}
