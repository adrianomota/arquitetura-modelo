

using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            ProdutoId = Guid.NewGuid();
        }

        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public Guid FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<Venda> VendaList { get; set; }
    }
}
