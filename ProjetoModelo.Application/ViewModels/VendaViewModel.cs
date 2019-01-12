using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class VendaViewModel
    {
        public VendaViewModel()
        {
            VendaId = Guid.NewGuid();
        }

        [Key]
        public Guid VendaId { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Tipo De Venda")]
        public TipoVendaViewEnum TipoVenda { get; set; }
        public ICollection<ProdutoViewModel> ProdutosList { get; set; }
        public Guid ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
