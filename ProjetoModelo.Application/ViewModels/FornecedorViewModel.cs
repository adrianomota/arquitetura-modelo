using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModelo.Application.ViewModels
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            FornecedorId = Guid.NewGuid();
        }

        [Key]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [MaxLength(14, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
        public virtual ICollection<EnderecoViewModel> EnderecoList { get; set; }
    }
}
