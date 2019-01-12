
using System.Data.Entity;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class VendaRepository : RepositoryBase<Venda, ProjetoModeloContext>, IVendaRepository
    {
        public override void Add(Venda venda)
        {
            Context.Set<Venda>().Add(venda);
            foreach (var produto in venda.ProdutosList)
            {
                Context.Entry(produto).State = EntityState.Unchanged;
            }
        }
    }
}
