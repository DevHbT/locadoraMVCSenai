using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosMVC.Data;
using VeiculosMVC.Models;

namespace locadoraMVCSenai.Repository
{
    public class SolicitacaoRepository : ISolicitacoesRepository
    {
        private readonly LocadoraContext _LocadoraContext;
        public SolicitacaoRepository(LocadoraContext locadoraContext){
            _LocadoraContext = locadoraContext;
        }
        public SolicitacaoModel Adicionar(SolicitacaoModel solicitacao)
        {
            _LocadoraContext.Solicitacoes.Add(solicitacao);
            _LocadoraContext.SaveChanges();
            return solicitacao;
        }
    }
}