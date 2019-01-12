using System;
using System.Collections.Generic;
using ProjetoModelo.Domain.Interfaces.Validation;
using ProjetoModelo.Domain.Validation.Clientes;
using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Domain.Entities
{
    public class Cliente : ISelfValidator
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
            EnderecoList = new List<Endereco>();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Venda> ProdutosComprados { get; set; }
        public virtual ICollection<Endereco> EnderecoList { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }

        public bool IsValid()
        {
            var fiscal = new ClienteEstaAptoParaCadastroNoSistema();

            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}
