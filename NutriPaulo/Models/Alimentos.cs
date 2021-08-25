using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class Alimentos
    {
        [Key]
        public int AlimentosId { get; set; }
        [DisplayName("Café Da Manhã")]
        public string CafeDaManha { get; set; }
        [DisplayName("Almoço")]
        public string Almoço { get; set; }
        [DisplayName("Lanche")]
        public string Lanche { get; set; }
        [DisplayName("Café")]
        public string CafeDaNoite { get; set; }

        public ICollection<Nutrientes> Nutrientes { get; set; }
    }
}
