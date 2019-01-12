using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModelo.Application.ViewModels
{
    public class EstadoViewModel
    {
        public EstadoViewModel()
        {
            EstadoId = Guid.NewGuid();
        }

        [Key]
        public Guid EstadoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(2)]
        public string UF { get; set; }

        public virtual IEnumerable<CidadeViewModel> Cidades { get; set; }
    }
}