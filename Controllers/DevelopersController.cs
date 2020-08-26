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
    public class DevelopersController : ControllerBase
    {
        private readonly DeveloperDbContext DesarrolladorContext;
        public DevelopersController(DeveloperDbContext DesarrolladorContexto)
        {
            DesarrolladorContext = DesarrolladorContexto;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Developer>>> GetDeveloperItems()
        {
            return await DesarrolladorContext.DeveloperItems.ToListAsync();
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Developer>> GetDeveloperItem(int DeveloperId)
        {
            var developerItem = await DesarrolladorContext.DeveloperItems.FindAsync(DeveloperId);
            if (developerItem == null)
            {
                return NotFound();
            }
            return developerItem;
        }
    }
}
