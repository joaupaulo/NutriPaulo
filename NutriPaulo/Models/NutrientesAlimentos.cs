using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class NutrientesAlimentos
    {
        public int AlimentosId { get; set; }
        public int NutrientesId { get; set; }

        public virtual Alimentos Alimentos { get; set; }
        public virtual Nutrientes Nutrientes { get; set; }
    }
}
