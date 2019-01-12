using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Domain.Interfaces.Validation
{
    public interface ISelfValidator
    {
        ValidationResult ResultadoValidacao { get; }
        bool IsValid(); 
    }
}