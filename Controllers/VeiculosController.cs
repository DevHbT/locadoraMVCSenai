using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VeiculosMVC.Models;
using VeiculosMVC.Repository;

namespace VeiculosMVC.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly IVeiculosRepository _veiculosRepository;

        public VeiculosController(IVeiculosRepository veiculosRepository)
        {
            _veiculosRepository = veiculosRepository;
        }

        public IActionResult Index()
        {
            var veiculos = _veiculosRepository.ListarVeiculos();
            return View(veiculos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(VeiculoModel veiculo)
        {
            if (ModelState.IsValid)
            {
                _veiculosRepository.Adicionar(veiculo);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Editar(int id)
        {
            VeiculoModel veiculo = _veiculosRepository.ListarId(id);
            return View(veiculo);
        }
        [HttpPost]
        public IActionResult Editar(VeiculoModel veiculo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _veiculosRepository.Editar(veiculo);
                    TempData["MensagemSucesso"] = "Veiculo alterado com sucesso!";
                    return RedirectToAction("Index");
                }
                return View("Editar", veiculo);
            }
            catch (Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu veiculo, tente novamente!, detalhe do erro:{error.Message}";
                return RedirectToAction("Index");
            }

        }

        public IActionResult VerificarDeletar(int id)
        {
            VeiculoModel veiculo = _veiculosRepository.ListarId(id);
            return View(veiculo);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
               bool apagar = _veiculosRepository.Deletar(id);
                if (apagar)
                {
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato!";
                }
                return RedirectToAction("Index");
            }
            catch(Exception error)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, tente novamente!, detalhe do erro:{error.Message}";
                return RedirectToAction("Index");
            }
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
             return View("Error!");
            }
    }
 }