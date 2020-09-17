﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Areas.Catalogo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task<IActionResult> Index(string pesquisa)
        {
            return View(await produtoRepository.GetProdutosAsync(pesquisa));
        }
    }
}
