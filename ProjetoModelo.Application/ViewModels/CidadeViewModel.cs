using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class CidadeViewModel
    {
        public CidadeViewModel()
        {
            CidadeId = Guid.NewGuid();
        }

        [Key]
        public Guid CidadeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public Guid EstadoId { get; set; }

        public virtual EstadoViewModel Estado { get; set; }
    }
}