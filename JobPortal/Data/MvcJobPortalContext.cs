using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobPortal.Models;

namespace MvcJobPortal.Data
{
    public class MvcJobPortalContext : DbContext
    {
        public MvcJobPortalContext (DbContextOptions<MvcJobPortalContext> options)
            : base(options)
        {
        }

        public DbSet<JobPortal.Models.Jobs> Jobs { get; set; } = default!;
    }
}
