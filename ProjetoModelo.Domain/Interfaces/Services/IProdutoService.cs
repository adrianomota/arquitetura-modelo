using System.Collections.Generic;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
