using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class Nutrientes
    {
        [Key]
        public int NutrientesId { get; set; }
        [DisplayName("Carboidratos")]
        public int Carboidratos { get; set; }

        [DisplayName("Proteinas")]
        public int Proteinas { get; set; }

        [DisplayName("Gorduras")]
        public int Gorduras { get; set; }

        [DisplayName("Sódio")]
        public int Sodio { get; set; }

        [DisplayName("Açucar")]
        public int Acucar { get; set; }

        public ICollection<Alimentos> Alimenntos { get; set; }
    }
}
