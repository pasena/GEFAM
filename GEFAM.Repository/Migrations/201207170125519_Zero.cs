namespace GEFAM.Repository.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Zero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DadoComplementar",
                c => new
                    {
                        DadosComplementaresID = c.Int(nullable: false, identity: true),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Hemofilia = c.Int(),
                        Inibidor = c.Int(),
                        Gestante = c.Decimal(precision: 18, scale: 2),
                        Transplantado_TranplantadoID = c.Int(),
                    })
                .PrimaryKey(t => t.DadosComplementaresID)
                .ForeignKey("Transplantado", t => t.Transplantado_TranplantadoID)
                .Index(t => t.Transplantado_TranplantadoID);
            
            CreateTable(
                "Transplantado",
                c => new
                    {
                        TranplantadoID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Orgao = c.String(maxLength: 150),
                        DataTransplante = c.DateTime(),
                    })
                .PrimaryKey(t => t.TranplantadoID);
            
            CreateTable(
                "Dispensacao",
                c => new
                    {
                        DispensacaoID = c.Int(nullable: false, identity: true),
                        QuantidadeAutorizada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataAutorizacao = c.DateTime(nullable: false),
                        QuantidadeDispensada = c.Decimal(precision: 18, scale: 2),
                        DataDispensa = c.DateTime(),
                        MedicamentoSolicitado_MedicamentoSolicitadoID = c.Int(),
                    })
                .PrimaryKey(t => t.DispensacaoID)
                .ForeignKey("MedicamentoSolicitado", t => t.MedicamentoSolicitado_MedicamentoSolicitadoID)
                .Index(t => t.MedicamentoSolicitado_MedicamentoSolicitadoID);
            
            CreateTable(
                "Endereco",
                c => new
                    {
                        EnderecoID = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(maxLength: 250),
                        Numero = c.Int(nullable: false),
                        PontoReferencia = c.String(maxLength: 250),
                        Bairro = c.String(maxLength: 150),
                        Municipio = c.String(maxLength: 150),
                        UF = c.String(maxLength: 2),
                        CEP = c.Int(nullable: false),
                        CodigoIBGE = c.String(),
                    })
                .PrimaryKey(t => t.EnderecoID);
            
            CreateTable(
                "Estabelecimento",
                c => new
                    {
                        EstabelecimentoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 250),
                        DIRES = c.String(maxLength: 250),
                        CNES = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstabelecimentoID);
            
            CreateTable(
                "Paciente",
                c => new
                    {
                        PacinteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 150),
                        CPF = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.Int(nullable: false),
                        RacaCor = c.Int(nullable: false),
                        NomeMae = c.String(maxLength: 150),
                        NomeResponsavel = c.String(maxLength: 150),
                        TelefoneContato = c.Int(nullable: false),
                        Endereco_EnderecoID = c.Int(),
                        Estabelecimento_EstabelecimentoID = c.Int(),
                    })
                .PrimaryKey(t => t.PacinteID)
                .ForeignKey("Endereco", t => t.Endereco_EnderecoID)
                .ForeignKey("Estabelecimento", t => t.Estabelecimento_EstabelecimentoID)
                .Index(t => t.Endereco_EnderecoID)
                .Index(t => t.Estabelecimento_EstabelecimentoID);
            
            CreateTable(
                "Solicitacao",
                c => new
                    {
                        SolicitacaoID = c.Int(nullable: false, identity: true),
                        NumeroProntuario = c.String(maxLength: 100),
                        Observacoes = c.String(maxLength: 500),
                        Monitoramento = c.Boolean(nullable: false),
                        Inclusao = c.DateTime(),
                        DataSolicitacao = c.DateTime(nullable: false),
                        DataAutorizacao = c.DateTime(nullable: false),
                        Solicitante_ProfissionalID = c.Int(),
                        Autorizador_ProfissionalID = c.Int(),
                        Paciente_PacinteID = c.Int(),
                        DadosComplementares_DadosComplementaresID = c.Int(),
                    })
                .PrimaryKey(t => t.SolicitacaoID)
                .ForeignKey("Profissional", t => t.Solicitante_ProfissionalID)
                .ForeignKey("Profissional", t => t.Autorizador_ProfissionalID)
                .ForeignKey("Paciente", t => t.Paciente_PacinteID)
                .ForeignKey("DadoComplementar", t => t.DadosComplementares_DadosComplementaresID)
                .Index(t => t.Solicitante_ProfissionalID)
                .Index(t => t.Autorizador_ProfissionalID)
                .Index(t => t.Paciente_PacinteID)
                .Index(t => t.DadosComplementares_DadosComplementaresID);
            
            CreateTable(
                "MedicamentoSolicitado",
                c => new
                    {
                        MedicamentoSolicitadoID = c.Int(nullable: false, identity: true),
                        Medicamento_MedicamentoID = c.Int(),
                        Solicitacao_SolicitacaoID = c.Int(),
                    })
                .PrimaryKey(t => t.MedicamentoSolicitadoID)
                .ForeignKey("Medicamento", t => t.Medicamento_MedicamentoID)
                .ForeignKey("Solicitacao", t => t.Solicitacao_SolicitacaoID)
                .Index(t => t.Medicamento_MedicamentoID)
                .Index(t => t.Solicitacao_SolicitacaoID);
            
            CreateTable(
                "Medicamento",
                c => new
                    {
                        MedicamentoID = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Nome = c.String(maxLength: 250),
                        CIDPrincipal = c.Int(nullable: false),
                        CIDSecundario = c.Int(nullable: false),
                        Posologia = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.MedicamentoID);
            
            CreateTable(
                "Profissional",
                c => new
                    {
                        ProfissionalID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 150),
                        CPF = c.Int(nullable: false),
                        CPFOrgaoExpedidor = c.String(maxLength: 50),
                        CNS = c.Int(nullable: false),
                        CNSOrgaoExpedidor = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ProfissionalID);
            
        }
        
        public override void Down()
        {
            DropIndex("MedicamentoSolicitado", new[] { "Solicitacao_SolicitacaoID" });
            DropIndex("MedicamentoSolicitado", new[] { "Medicamento_MedicamentoID" });
            DropIndex("Solicitacao", new[] { "DadosComplementares_DadosComplementaresID" });
            DropIndex("Solicitacao", new[] { "Paciente_PacinteID" });
            DropIndex("Solicitacao", new[] { "Autorizador_ProfissionalID" });
            DropIndex("Solicitacao", new[] { "Solicitante_ProfissionalID" });
            DropIndex("Paciente", new[] { "Estabelecimento_EstabelecimentoID" });
            DropIndex("Paciente", new[] { "Endereco_EnderecoID" });
            DropIndex("Dispensacao", new[] { "MedicamentoSolicitado_MedicamentoSolicitadoID" });
            DropIndex("DadoComplementar", new[] { "Transplantado_TranplantadoID" });
            DropForeignKey("MedicamentoSolicitado", "Solicitacao_SolicitacaoID", "Solicitacao");
            DropForeignKey("MedicamentoSolicitado", "Medicamento_MedicamentoID", "Medicamento");
            DropForeignKey("Solicitacao", "DadosComplementares_DadosComplementaresID", "DadoComplementar");
            DropForeignKey("Solicitacao", "Paciente_PacinteID", "Paciente");
            DropForeignKey("Solicitacao", "Autorizador_ProfissionalID", "Profissional");
            DropForeignKey("Solicitacao", "Solicitante_ProfissionalID", "Profissional");
            DropForeignKey("Paciente", "Estabelecimento_EstabelecimentoID", "Estabelecimento");
            DropForeignKey("Paciente", "Endereco_EnderecoID", "Endereco");
            DropForeignKey("Dispensacao", "MedicamentoSolicitado_MedicamentoSolicitadoID", "MedicamentoSolicitado");
            DropForeignKey("DadoComplementar", "Transplantado_TranplantadoID", "Transplantado");
            DropTable("Profissional");
            DropTable("Medicamento");
            DropTable("MedicamentoSolicitado");
            DropTable("Solicitacao");
            DropTable("Paciente");
            DropTable("Estabelecimento");
            DropTable("Endereco");
            DropTable("Dispensacao");
            DropTable("Transplantado");
            DropTable("DadoComplementar");
        }
    }
}
