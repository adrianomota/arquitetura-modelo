using System;
using System.Linq;
using System.Web.Mvc;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IEstadoAppService _estadoApp;
        private readonly ICidadeAppService _cidadeApp;
        private readonly IEnderecoAppService _enderecoApp;

        public ClientesController(
            IClienteAppService clienteApp, 
            IEstadoAppService estadoApp, 
            ICidadeAppService cidadeApp, 
            IEnderecoAppService enderecoApp)
        {
            _clienteApp = clienteApp;
            _estadoApp = estadoApp;
            _cidadeApp = cidadeApp;
            _enderecoApp = enderecoApp;
        }

        // GET: Cliente
        public ViewResult Index()
        {
            var clienteViewModel = _clienteApp.GetAll();

            return View(clienteViewModel);
        }


        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            var clienteViewModel = _clienteApp.GetById(id);
            //clienteViewModel.Enderecos = _enderecoApp.ObterPorCliente(id);

            return View(clienteViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll().OrderBy(e => e.Nome), "EstadoId", "Nome");
            ViewBag.CidadeId = new SelectList(_cidadeApp.GetAll().OrderBy(c => c.Nome), "CidadeId", "Nome");

            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteEnderecoViewModel clienteEndereco)
        {
            ViewBag.EstadoId = new SelectList(_estadoApp.GetAll().OrderBy(e => e.Nome), "EstadoId", "Nome", clienteEndereco.EstadoId);
            ViewBag.CidadeId = new SelectList(_cidadeApp.GetAll().OrderBy(c => c.Nome), "CidadeId", "Nome", clienteEndereco.CidadeId);

            if (ModelState.IsValid)
            {
                var result = _clienteApp.Add(clienteEndereco);

                if (!result.IsValid)
                {
                    foreach (var validationAppError in result.Erros)
                    {
                        ModelState.AddModelError(string.Empty, validationAppError.Message);
                    }
                    return View(clienteEndereco);
                }

                return RedirectToAction("Index");
            }
     
            return View(clienteEndereco);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
            var clienteViewModel = _clienteApp.GetById(id);

            return View(clienteViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteApp.Update(clienteViewModel);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
            var clienteViewModel = _clienteApp.GetById(id);

            return View(clienteViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
