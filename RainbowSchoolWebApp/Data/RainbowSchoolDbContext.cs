using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolWebApp.Models;

namespace RainbowSchoolWebApp.Data
{
    public class RainbowSchoolDbContext : DbContext
    {
        public RainbowSchoolDbContext (DbContextOptions<RainbowSchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolWebApp.Models.Student> Student { get; set; } = default!;
    }
}
