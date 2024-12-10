using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VeiculosMVC.Data;
using VeiculosMVC.Models;

namespace VeiculosMVC.Repository
{
    public class VeiculosRepository : IVeiculosRepository
    {
        private readonly LocadoraContext _locadoraContext;
        public VeiculosRepository(LocadoraContext locadoraContext){
            _locadoraContext = locadoraContext;
        }
        public VeiculoModel Adicionar(VeiculoModel veiculo)
        {
            _locadoraContext.Veiculos.Add(veiculo);
            _locadoraContext.SaveChanges();
            return veiculo;
        }

        public bool Deletar(int id)
        {
            VeiculoModel veiculoDB = ListarId(id);
            if(veiculoDB == null) throw new Exception("Houve um erro ao deletar o Veiculo!");
            _locadoraContext.Veiculos.Remove(veiculoDB);
            _locadoraContext.SaveChanges();
            return true;
        }

        public VeiculoModel Editar(VeiculoModel veiculo)
        {
            VeiculoModel veiculoDB = ListarId(veiculo.Id);
            if(veiculoDB == null) throw new Exception("Houve um Erro na atualização do Veiculo!");
            veiculoDB.Marca = veiculo.Marca;
            veiculoDB.Modelo = veiculo.Modelo;
            veiculoDB.PrecoPorDia = veiculo.PrecoPorDia;
            veiculoDB.FotoUrl = veiculo.FotoUrl;

            _locadoraContext.Veiculos.Update(veiculoDB);
            _locadoraContext.SaveChanges();
            return veiculoDB;
        }

        public VeiculoModel ListarId(int id)
        {
            return _locadoraContext.Veiculos.FirstOrDefault(x => x.Id == id);
        }

        public List<VeiculoModel> ListarVeiculos(){
            return _locadoraContext.Veiculos.ToList();
        }


    }
}