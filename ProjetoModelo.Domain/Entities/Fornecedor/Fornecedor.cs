using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            FornecedorId = Guid.NewGuid();
        }

        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }
        public virtual ICollection<Endereco> EnderecoList { get; set; }
    }
}
