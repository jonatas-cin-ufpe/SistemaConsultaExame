using SistemaConsultaExames.Domain.Entities;
using SistemaConsultaExames.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SistemaConsultaExames.Infra.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("SistemaConsultaExameDDD")
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<ExamesTipo> TiposDeExame { get; set; }
        public DbSet<Exame> Exames { get; set; }

        public DbSet<MarcacaoConsulta> MarcacoesConsultas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new ExamesTipoConfiguration());
            modelBuilder.Configurations.Add(new ExameConfiguration());
            modelBuilder.Configurations.Add(new MarcacaoConsultaConfiguration());

        }

    }
}
