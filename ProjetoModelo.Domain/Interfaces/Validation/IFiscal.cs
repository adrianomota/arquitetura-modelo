using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Domain.Interfaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
