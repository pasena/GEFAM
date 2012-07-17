using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Solicitacao
    {
        public int SolicitacaoID { get; set; }
        public string NumeroProntuario { get; set; }
        public string Observacoes { get; set; }
        public bool Monitoramento { get; set; }
        public DateTime? Inclusao { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public DateTime DataAutorizacao { get; set; }

        public virtual ICollection<MedicamentoSolicitado> MedicamentosSolicitados { get; set; }

        public virtual Profissional Solicitante { get; set; }

        public virtual Profissional Autorizador { get; set; }
    }
}
