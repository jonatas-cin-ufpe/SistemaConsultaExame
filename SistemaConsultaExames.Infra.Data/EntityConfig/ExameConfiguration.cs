using System.Data.Entity.ModelConfiguration;
using SistemaConsultaExames.Domain.Entities;

namespace SistemaConsultaExames.Infra.Data.EntityConfig
{
    class ExameConfiguration : EntityTypeConfiguration<Exame>
    {     
        public ExameConfiguration()
        {

            HasKey(e => e.Id);

            Property(e => e.Id)
                   .IsRequired();

            Property(e => e.Observacao)
                   .IsRequired()
                   .HasMaxLength(1000);

        }
    }
}
