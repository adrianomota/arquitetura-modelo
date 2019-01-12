using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entities
{
    public class Venda
    {
        public Venda()
        {
            VendaId = Guid.NewGuid();
            ProdutosList = new List<Produto>();
        }

        public Guid VendaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoVenda TipoVenda { get; set; }
        public ICollection<Produto> ProdutosList { get; set; }
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
