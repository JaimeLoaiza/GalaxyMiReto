using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMiReto.GalaxyMiReto.Models
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        [Required]
        public string IdentityType { get; set; }
        public string NumberIdentity { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SeconLastName { get; set; }
        public string DateBirth { get; set; }
        public string Age { get; set; }
        [ForeignKey("ContractId")]
        public virtual Contrato Contrato { get; set; }
    }
}
