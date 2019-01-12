using System.Data.Entity.ModelConfiguration;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

            Ignore(t => t.ResultadoValidacao);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);

            HasMany(f => f.EnderecoList)
                .WithMany(e => e.ClienteList)
                .Map(me =>
                {
                    me.MapLeftKey("ClienteId");
                    me.MapRightKey("EnderecoId");
                    me.ToTable("EnderecosCliente");
                });
        }
    }
}
