using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class RelatorioPrincipal
    {
        [Key]
        public int RelatorioPrincipalId { get; set; }
        public int PessoasId { get; set; }
        public virtual Pessoas Pessoas { get; set; }
    }
}
