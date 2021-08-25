using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class Pessoas
    {
        public int PessoasId { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public int CPF { get; set; }

        public int RG { get; set; }

        public string Email { get; set; }

        public List<Enderecos> Enderecos { get; set; }

        public CaracteristicasFisicas CaracteristicasFisicas { get; set; }
    }
}
