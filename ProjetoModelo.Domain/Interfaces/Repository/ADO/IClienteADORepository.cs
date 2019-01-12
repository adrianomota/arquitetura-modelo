using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Domain.Interfaces.Repository.ADO
{
    public interface IClienteADORepository
    {
        IEnumerable<Cliente> GetAll();
    }
}
