using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace VeiculosMVC.Controllers
{
    public class SolicitacoesController : Controller
    {
        private readonly ILogger<SolicitacoesController> _logger;

        public SolicitacoesController(ILogger<SolicitacoesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Criar()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}