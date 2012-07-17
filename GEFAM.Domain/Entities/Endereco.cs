using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Endereco
    {
        [Key]
        public int EnderecoID { get; set; }

        [StringLength(250)]
        public string Logradouro { get; set; }

        [StringLength(250)]
        public string Complemento { get; set; }

        public int Numero { get; set; }

        [StringLength(250)]
        public string PontoReferencia { get; set; }

        [StringLength(150)]
        public string Bairro { get; set; }

        [StringLength(150)]
        public string Municipio { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        public int CEP { get; set; }

        public string CodigoIBGE { get; set; }
    }
}
