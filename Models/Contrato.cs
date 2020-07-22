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
        [Column("ContractId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ContractId { get; set; }
        [Column("ContractNumber")]
        [Required]
        [StringLength(5)]
        public int ContractNumber { get; set; }
        [Column("EntityName")]
        [Required]
        [StringLength(50)]
        public string EntityName { get; set; }
        [Column("ContractWorker")]
        [Required]
        [StringLength(2)]
        public string ContractWorker { get; set; }
        [Column("InitialDate")]
        [Required]
        [StringLength(8)]
        public string InitialDate { get; set; }
        [Column("FinalDate")]
        [Required]
        [StringLength(8)]
        public string FinalDate { get; set; }
    }
}
