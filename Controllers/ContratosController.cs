using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalaxyMiReto.Data;
using GalaxyMiReto.GalaxyMiReto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GalaxyMiReto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly ContratodbContext FirmaContext;
        public ContratosController(ContratodbContext FirmaContexto)
        {
            FirmaContext = FirmaContexto;
        }
        //Primer metodo de tipo Get: api/contrato
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContratoItems()
        {
            return await FirmaContext.ContratoItems.ToListAsync();
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Contrato>> GetContratoItem(int ContratoId)
        {
            var contratoItem = await FirmaContext.ContratoItems.FindAsync(ContratoId);
            if(contratoItem == null)
            {
                return NotFound();
            }
            return contratoItem;
        }
    }
}
