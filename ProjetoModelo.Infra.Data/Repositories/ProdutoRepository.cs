using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto, ProjetoModeloContext>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return base.Find(c => c.Nome == nome);
        }
    }
}
