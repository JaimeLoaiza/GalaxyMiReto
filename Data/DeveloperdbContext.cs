using GalaxyMiReto.GalaxyMiReto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMiReto.Data
{
    public class DeveloperDbContext:DbContext
    {
        public DeveloperDbContext(DbContextOptions<DeveloperDbContext>options):base(options)
        { 
        }
        public DbSet<Developer> DeveloperItems { get; set; }
    }
}
