using System;
using System.Web.Mvc;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        private readonly IProdutoAppService _produtoApp;
        private readonly IFornecedorAppService _fornecedorApp;

        public ProdutosController(IProdutoAppService produtoApp, IFornecedorAppService fornecedorApp)
        {
            _produtoApp = produtoApp;
            _fornecedorApp = fornecedorApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View(_produtoApp.GetAll());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(Guid id)
        {
            var produtoViewModel = _produtoApp.GetById(id);

            return View(produtoViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome");
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoApp.Add(produtoViewModel);

                return RedirectToAction("Index");
            }

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", produtoViewModel.FornecedorId);
            return View(produtoViewModel);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(Guid id)
        {
            var produtoViewModel = _produtoApp.GetById(id);

            ViewBag.FornecedorId = new SelectList(_fornecedorApp.GetAll(), "FornecedorId", "Nome", produtoViewModel.FornecedorId);

            return View(produtoViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtoApp.Update(produtoViewModel);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(_fornecedorApp.GetAll(), "ClienteId", "Nome", produtoViewModel.FornecedorId);
            return View(produtoViewModel);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(Guid id)
        {
            var produtoViewModel = _produtoApp.GetById(id);

            return View(produtoViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _produtoApp.Remove(_produtoApp.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
