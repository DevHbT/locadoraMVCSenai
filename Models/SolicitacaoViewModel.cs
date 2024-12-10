using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeiculosMVC.Models;

namespace locadoraMVCSenai.Models
{
    public class SolicitacaoViewModel
    {
        public VeiculoModel Veiculo { get; set; }
        public SolicitacaoModel Solicitacao { get; set; }
        public decimal TotalDias { get; set; }
        public decimal ValorTotal { get; set; }
    }
}