using System;
using System.Web.Mvc;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Application.ViewModels;

namespace ProjetoModelo.MVC.Controllers
{
    public class FornecedoresController : Controller
    {

        private readonly IFornecedorAppService _fornecedorApp;

        public FornecedoresController(IFornecedorAppService fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }

        // GET: Fornecedores
        public ActionResult Index()
        {
            return View(_fornecedorApp.GetAll());
        }

        // GET: Fornecedores/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_fornecedorApp.GetById(id));
        }

        // GET: Fornecedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorApp.Add(fornecedor);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_fornecedorApp.GetById(id));
        }

        // POST: Fornecedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorApp.Update(fornecedor);

                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_fornecedorApp.GetById(id));
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _fornecedorApp.Remove(_fornecedorApp.GetById(id));

            return RedirectToAction("Index");
        }
    }
}
