using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GEFAM.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GEFAM.Repository.Concrete
{
    public class GEFAMContext : DbContext
    {
        public DbSet<DadoComplementar> DadosComplementares { get; set; }
        public DbSet<Dispensacao> Dispensacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<MedicamentoSolicitado> MedicamentosSolicitados { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }
        public DbSet<Transplantado> Transplantados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
