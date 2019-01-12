using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(f => f.FornecedorId);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(f => f.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(f => f.CNPJ)
                .IsRequired()
                .HasMaxLength(14);

            Property(f => f.Ativo)
                .IsRequired();

            Property(f => f.DataCadastro)
                .IsRequired();

            HasMany(f => f.EnderecoList)
                .WithMany(e => e.FornecedorList)
                .Map(me =>
                {
                    me.MapLeftKey("FornecedorId");
                    me.MapRightKey("EnderecoId");
                    me.ToTable("EnderecosFornecedor");
                });
        }
    }
}
