using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Profissional
    {
        public int ProfissionalID { get; set; }
        
        public string Nome { get; set; }
        
        public int CPF { get; set; }

        public string CPFOrgaoExpedidor { get; set; }

        public int CNS { get; set; }

        public string CNSOrgaoExpedidor { get; set; }
    }
}
