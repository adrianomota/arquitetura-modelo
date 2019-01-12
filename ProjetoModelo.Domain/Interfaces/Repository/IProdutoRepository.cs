using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
