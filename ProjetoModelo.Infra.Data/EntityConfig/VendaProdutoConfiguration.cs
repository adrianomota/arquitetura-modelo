using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.EntityConfig
{
    public class VendaConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaConfiguration()
        {
            HasKey(v => v.VendaId);

            Property(v => v.Valor)
                .IsRequired();

            Property(v => v.DataCadastro)
                .IsRequired();

            Property(v => v.TipoVenda)
                .IsRequired();

            HasMany(v => v.ProdutosList)
                .WithMany(p => p.VendaList)
                .Map(me =>
                {
                    me.MapLeftKey("VendaId");
                    me.MapRightKey("ProdutoId");
                    me.ToTable("VendaProdutos");
                });
        }
    }
}
