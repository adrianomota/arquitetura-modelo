using System;

namespace ProjetoModelo.Domain.Entities
{
    public class Cidade
    {
        public Cidade()
        {
            CidadeId = Guid.NewGuid();
        }

        public Guid CidadeId { get; set; }
        public string Nome { get; set; }
        public Guid EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
