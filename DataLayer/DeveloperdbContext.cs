using GalaxyMiReto.GalaxyMiReto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMiReto.DataLayer
{
    public class DeveloperdbContext:DbContext
    {
        public DeveloperdbContext(DbContextOptions
            <DeveloperdbContext>options):base(options)
        { 
        }
        public DbSet<Developer>Developer { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
    }
}
