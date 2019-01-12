using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Repository.ADO;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteReadOnlyRepository _clienteReadOnlyRepository;
        private readonly IClienteADORepository _clienteAdoRepository;

        public ClienteService(
            IClienteRepository clienteRepository, 
            IClienteReadOnlyRepository clienteReadOnlyRepository, 
            IClienteADORepository clienteAdoRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _clienteReadOnlyRepository = clienteReadOnlyRepository;
            _clienteAdoRepository = clienteAdoRepository;
        }

        public override Cliente GetById(Guid id)
        {
            return _clienteReadOnlyRepository.GetById(id);
        }

        public override IEnumerable<Cliente> GetAll()
        {
            return _clienteAdoRepository.GetAll();
        }

        public ValidationResult AdicionarCliente(Cliente cliente)
        {
            var resultadoValidacao = new ValidationResult();

            if (!cliente.IsValid())
            {
                resultadoValidacao.AdicionarErro(cliente.ResultadoValidacao);
                return resultadoValidacao;
            }

            base.Add(cliente);

            return resultadoValidacao;
        }
    }
}
