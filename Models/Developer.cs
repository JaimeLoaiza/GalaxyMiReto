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
        [Column("DeveloperId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DeveloperId { get; set; }
        [Column("NumberId")]
        [Required]
        [StringLength(5)]
        public string NumberId { get; set; }
        [Column("FirstName")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("SecondName")]
        [Required]
        [StringLength(50)]
        public string SecondName { get; set; }
        [Column("FirstLastName")]
        [Required]
        [StringLength(50)]
        public string FirstLastName { get; set; }
        [Column("SecondLastName")]
        [Required]
        [StringLength(50)]
        public string SeconLastName { get; set; }
        [Column("DateBirth")]
        [Required]
        [StringLength(8)]
        public string DateBirth { get; set; }
        [Column("Age")]
        [Required]
        [StringLength(2)]
        public string Age { get; set; }
        [ForeignKey("ContractNumberId")]
        public virtual ContractNumber ContractNumber { get; set; }
    }
}
