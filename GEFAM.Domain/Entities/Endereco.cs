using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoID { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string PontoReferencia { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public int CEP { get; set; }
        public string CodigoIBGE { get; set; }
    }
}
