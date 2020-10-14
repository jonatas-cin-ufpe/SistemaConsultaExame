using System.Data.Entity.ModelConfiguration;
using SistemaConsultaExames.Domain.Entities;

namespace SistemaConsultaExames.Infra.Data.EntityConfig
{
    class MarcacaoConsultaConfiguration : EntityTypeConfiguration<MarcacaoConsulta>
    {

        public MarcacaoConsultaConfiguration()
        {

            HasKey(m => m.Protocolo);

            Property(m => m.Protocolo)
                       .IsRequired();

            Property(m => m.Horario)
                       .IsRequired();

            HasIndex(m => m.Horario)
                       .IsUnique();

            HasRequired(m => m.Paciente)
                .WithMany()
                .HasForeignKey(m => m.PacienteCPF);
        }

    }
}
