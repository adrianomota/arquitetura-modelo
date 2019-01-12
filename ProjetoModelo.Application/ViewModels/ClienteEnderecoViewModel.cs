using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
        {
            ClienteId = Guid.NewGuid();
            EnderecoId = Guid.NewGuid();
        }

        // Cliente
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        // Endereço
        public Guid EnderecoId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Rua { get; set; }

        [Required]
        [MaxLength(6)]
        [DisplayName("Número")]
        public string Numero { get; set; }

        [MaxLength(100)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(8)]
        public string CEP { get; set; }

        [Required]
        [DisplayName("Estado")]
        public Guid EstadoId { get; set; }

        [Required]
        [DisplayName("Cidade")]
        public Guid CidadeId { get; set; }
    }
}