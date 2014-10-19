using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaTecnica.Rh.Models
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key]
        public int idVaga { get; set; }

        [Display(Name = "Vaga")]
        [Required]
        public string nomeVaga { get; set; }
    }
}