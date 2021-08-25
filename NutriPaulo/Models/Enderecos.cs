using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutriPaulo.Models
{
    public class Enderecos
    {

        public int EnderecosId { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int PessoasId { get; set; }
        public Pessoas Pessoas { get; set; }
    }
}
