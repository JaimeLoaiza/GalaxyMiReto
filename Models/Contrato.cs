using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMiReto.GalaxyMiReto.Models
{
    public class Contrato
    {
        public int ContratoId { get; set; }
        [Required]
        public int ContratoNumero { get; set; }
        public string EntityName { get; set; }
        public string ContractWorker { get; set; }
        public string InitialDate { get; set; }
        public string FinalDate { get; set; }
    }
}
