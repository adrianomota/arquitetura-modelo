using System;
using System.Collections.Generic;

namespace ProjetoModelo.Domain.Entities
{
    public class Estado
    {
        public Estado()
        {
            EstadoId = Guid.NewGuid();
        }

        public Guid EstadoId { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public virtual IEnumerable<Cidade> Cidades { get; set; }
    }
}
