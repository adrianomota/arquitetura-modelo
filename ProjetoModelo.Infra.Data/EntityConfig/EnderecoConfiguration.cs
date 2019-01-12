using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Rua)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired();

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(e => e.Estado)
                .WithMany()
                .HasForeignKey(e => e.EstadoId);

            HasRequired(e => e.Cidade)
                .WithMany()
                .HasForeignKey(e => e.CidadeId);

        }
    }
}
