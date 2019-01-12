using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Infra.Data.Context;

namespace ProjetoModelo.Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco,ProjetoModeloContext>, IEnderecoRepository
    {
    }
}
