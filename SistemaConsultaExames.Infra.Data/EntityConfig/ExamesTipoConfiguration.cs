using System.Data.Entity.ModelConfiguration;
using SistemaConsultaExames.Domain.Entities;

namespace SistemaConsultaExames.Infra.Data.EntityConfig
{
    class ExamesTipoConfiguration : EntityTypeConfiguration<ExamesTipo>
    {
        public ExamesTipoConfiguration()
        {
            HasKey(e => e.Nome);

            Property(e => e.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(256);

        }
    }
}
