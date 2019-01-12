using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            ProdutoId = Guid.NewGuid();
        }

        [Key]
        public Guid ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public Guid FornecedorId { get; set; }

        public virtual FornecedorViewModel Fornecedor { get; set; }
    }
}