using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosMVC.Models
{
    public class SolicitacaoModel
    {
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int VeiculoId { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; } // "Pendente", "Aprovada", "Rejeitada"
    public UsuarioModel Usuario { get; set; }
    public VeiculoModel Veiculo { get; set; }
    }
}