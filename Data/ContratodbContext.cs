using GalaxyMiReto.GalaxyMiReto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMiReto.Data
{
    public class ContratodbContext:DbContext
    {
        public ContratodbContext(DbContextOptions<ContratodbContext> options) : base(options)
        { 
        }
        public DbSet<Contrato> ContratoItems { get; set; }
    }
}
