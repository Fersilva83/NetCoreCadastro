
using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
    {
        public class ProductsController : Controller
        {
            private readonly IProductViewModelService _produtoViewModelService;

        public ProductsController(IProductViewModelService produtoViewModelService)
            {
                _produtoViewModelService = produtoViewModelService;
            }

        // GET: Produtos
        public ActionResult Index()
            {
                var list = _produtoViewModelService.GetAll();
                return View(list);
            }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
            {
                var viewModel = _produtoViewModelService.Get(id);
                return View(viewModel);
            }

        // GET: Produtos/Create
        public ActionResult Create()
            {
                return View();
            }

        // POST: Produtos/Create
        [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(ProdutoViewModel viewModel)
            {
                try
                {

                    if (ModelState.IsValid)
                    {
                        _produtoViewModelService.Insert(viewModel);

                        return RedirectToAction(nameof(Index));
                    }
                    return View(viewModel);
                }
                catch
                {
                    return View(viewModel);
                }
            }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
            {
                var viewModel = _produtoViewModelService.Get(id);
                return View(viewModel);
            }

        // POST: Produtos/Edit/5
        [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int id, ProdutoViewModel viewModel)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _produtoViewModelService.Update(viewModel);

                        return RedirectToAction(nameof(Index));
                    }
                    return View(viewModel);
                }
                catch
                {
                    return View(viewModel);
                }
            }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
            {
                var viewModel = _produtoViewModelService.Get(id);
                return View(viewModel);
            }

        // POST: Produtos/Delete/5
        [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        _produtoViewModelService.Delete(id);

                        return RedirectToAction(nameof(Index));
                    }

                    var viewModel = _produtoViewModelService.Get(id);
                    return View(viewModel);
                }
                catch
                {
                    var viewModel = _produtoViewModelService.Get(id);
                    return View(viewModel);
                }
            }
        }
    }

