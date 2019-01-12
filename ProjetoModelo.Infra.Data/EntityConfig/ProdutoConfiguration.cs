using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
