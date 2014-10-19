using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaTecnica.Rh.Models
{

    [Table("Candidato")]
    public class Candidato
    {
        [Key]
        public int idCandidato { get; set; }
        
        [Display(Name = "Nome")]
        [Required]
        public string nomeCandidato { get; set; }
        
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "Telefone")]
        public string telefoneCandidato { get; set; }

        public virtual Vaga Vaga { get; set; }
        
        public IList<Tecnologia> Tecnologia { get; set; }
    }
}
