using System.Data.Entity.ModelConfiguration;
using SistemaConsultaExames.Domain.Entities;

namespace SistemaConsultaExames.Infra.Data.EntityConfig
{
    class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            HasKey(p => p.CPF);
                
            HasIndex(p => p.CPF)
                .IsUnique();

            Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

            Property(p => p.Nascimento)
                    .IsRequired();

            Property(p => p.Sexo)
                   .IsRequired();

            Property(p => p.Telefone)
                   .IsRequired()
                   .HasMaxLength(15); ;

            Property(c => c.Email)
                    .IsRequired();

        }
    }
}
