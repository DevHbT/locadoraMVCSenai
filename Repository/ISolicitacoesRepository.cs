using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosMVC.Data;
using VeiculosMVC.Models;

namespace locadoraMVCSenai.Repository
{
    public interface ISolicitacoesRepository
    {
        
        SolicitacaoModel Adicionar(SolicitacaoModel solicitacao);

    }
}