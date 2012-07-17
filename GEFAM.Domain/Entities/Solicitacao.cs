using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Solicitacao
    {
        [Key]
        public int SolicitacaoID { get; set; }

        [StringLength(100)]
        public string NumeroProntuario { get; set; }

        [StringLength(500)]
        public string Observacoes { get; set; }

        public bool Monitoramento { get; set; }

        public DateTime? Inclusao { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public DateTime DataAutorizacao { get; set; }

        public virtual ICollection<MedicamentoSolicitado> MedicamentosSolicitados { get; set; }

        public virtual Profissional Solicitante { get; set; }

        public virtual Profissional Autorizador { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual DadoComplementar DadosComplementares { get; set; }

    }
}
