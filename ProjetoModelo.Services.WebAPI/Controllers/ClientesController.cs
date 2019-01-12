using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using Newtonsoft.Json;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Services.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _clienteApp;

        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: api/Clientes
        public IEnumerable<ClienteViewModel> Get()
        {
            return _clienteApp.GetAll();
        }

        public SysDataTablePager<string[][]> Get(Guid id)
        {
            var cliente =_clienteApp.GetById(id).Enderecos.First(); 

            var retorno = new SysDataTablePager<string[][]>();
            var nvc = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var sEcho = nvc["sEcho"];

            retorno.sEcho = sEcho;
            retorno.iTotalDisplayRecords = 1;
            retorno.iTotalRecords = 1;
            retorno.aaData = new[]
            {
                new[]
                {
                    cliente.Rua,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    cliente.CEP,
                    cliente.Estado.Nome,
                    cliente.Cidade.Nome
                }
            };

            return retorno;
        }

        // POST: api/Clientes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }

        public class SysDataTablePager<T>
        {
            public string sEcho { get; set; }
            public int iTotalRecords { get; set; }
            public int iTotalDisplayRecords { get; set; }

            public string[][] aaData { get; set; }
        }
    }
}