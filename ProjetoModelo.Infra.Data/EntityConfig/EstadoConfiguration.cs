using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(e => e.EstadoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.UF)
                .IsRequired()
                .HasMaxLength(2);
        }
    }
}
