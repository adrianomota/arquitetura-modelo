using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Specification;

namespace ProjetoModelo.Domain.Specification.Produtos
{
    public class ProdutoTemValorAcimaDeZero : ISpecification<Produto>
    {
        public bool IsSatisfiedBy(Produto produto)
        {
            return produto.Valor > 0;
        }
    }
}
