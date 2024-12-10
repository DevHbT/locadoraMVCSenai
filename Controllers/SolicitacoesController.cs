using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using locadoraMVCSenai.Models;
using locadoraMVCSenai.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VeiculosMVC.Data;
using VeiculosMVC.Models;
using VeiculosMVC.Repository;

namespace VeiculosMVC.Controllers
{
    public class SolicitacoesController : Controller
    {
        private readonly IVeiculosRepository _veiculosRepository;

        private readonly LocadoraContext _locadoraContext;

        private readonly ISolicitacoesRepository _solicitacoesRepository;

        public SolicitacoesController(IVeiculosRepository veiculosRepository, ISolicitacoesRepository solicitacaoRepository)
        {
            _solicitacoesRepository = solicitacaoRepository;
            _veiculosRepository = veiculosRepository;
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Criar(int id)
        {
            var veiculos = _veiculosRepository.ListarId(id);
            var solicitacao = new SolicitacaoModel();
            
            var ViewModel = new SolicitacaoViewModel{
                Veiculo = veiculos,
                Solicitacao = solicitacao
            };

            return View(ViewModel);
        }

        [HttpPost]
        public IActionResult Criar(SolicitacaoModel solicitacao)
        {
            if(ModelState.IsValid){
                _solicitacoesRepository.Adicionar(solicitacao);
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}