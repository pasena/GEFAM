using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Transplantado
    {
        public int TranplantadoID { get; set; }
        public int Quantidade { get; set; }
        public string Orgao { get; set; }
        public DateTime DataTransplante { get; set; }
    }
}
