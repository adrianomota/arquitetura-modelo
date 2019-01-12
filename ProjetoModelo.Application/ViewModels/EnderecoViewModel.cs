using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }

        [Key]
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

        [Required]
        public Guid ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
        
        public virtual CidadeViewModel Cidade { get; set; }
        
        public virtual EstadoViewModel Estado { get; set; }
    }
}