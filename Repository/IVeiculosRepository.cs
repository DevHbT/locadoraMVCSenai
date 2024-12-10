using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosMVC.Models;

namespace VeiculosMVC.Repository
{
    public interface IVeiculosRepository
    {
        VeiculoModel Adicionar(VeiculoModel veiculo);
        VeiculoModel ListarId(int id);
        List<VeiculoModel> ListarVeiculos();
        VeiculoModel Editar(VeiculoModel veiculo);
        bool Deletar(int id);

    }
}