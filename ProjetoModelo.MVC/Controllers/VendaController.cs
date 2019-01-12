using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.MVC.Controllers
{
    public class VendaController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly IClienteAppService _clienteAppService;
        private readonly IVendaAppService _vendaAppService;

        public VendaController(
            IProdutoAppService produtoAppService, 
            IClienteAppService clienteAppService, 
            IVendaAppService vendaAppService)
        {
            _produtoAppService = produtoAppService;
            _clienteAppService = clienteAppService;
            _vendaAppService = vendaAppService;
        }

        // GET: Venda
        public ActionResult Index()
        {
            ViewBag.ClienteId = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome");
 
            return View(_produtoAppService.GetAll());
        }

        [HttpPost]
        public ActionResult Venda(Guid id, FormCollection collection)
        {
            var ClienteId = collection["ClienteId"].Split(',').First();
            var produto = _produtoAppService.GetById(id);

            var venda = new VendaViewModel
            {
                ClienteId = Guid.Parse(ClienteId),
                ProdutosList = new List<ProdutoViewModel> { produto },
                TipoVenda = TipoVendaViewEnum.Vista,
                Valor = produto.Valor
            };


            _vendaAppService.Add(venda);

            return View("ProdutosVendidos", _vendaAppService.GetAll());
        }
    }
}