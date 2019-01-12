using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Specification.Clientes;
using ProjetoModelo.Domain.Validation.Base;

namespace ProjetoModelo.Domain.Validation.Clientes
{
    public class ClienteEstaAptoParaCadastroNoSistema : FiscalBase<Cliente>
    {
        public ClienteEstaAptoParaCadastroNoSistema()
        {
            var clienteEndereco = new ClientePossuiEnderecoCadastradoSpecification();
            var clienteAtivo = new ClientePossuiStatusAtivo();
            var clienteCPFValido = new ClientePossuiCPFValido();

            base.AdicionarRegra("ClienteEspecial", new Regra<Cliente>(clienteEndereco, "Cliente não possui endereço castrado"));
            base.AdicionarRegra("ClienteAtivo", new Regra<Cliente>(clienteAtivo, "Cliente não está ativo no sistema"));
            base.AdicionarRegra("ClienteCPFValido", new Regra<Cliente>(clienteCPFValido, "Cliente informou um CPF Inválido"));
        }
    }
}
