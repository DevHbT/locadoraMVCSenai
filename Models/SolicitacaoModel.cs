using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosMVC.Models
{
    public class SolicitacaoModel
    {
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int VeiculoId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string Status { get; set; } // "Pendente", "Aprovada", "Rejeitada"
    [ForeignKey("UsarioId")]
    public UsuarioModel Usuario { get; set; }

    [ForeignKey("VeiculoId")]
    public VeiculoModel Veiculo { get; set; }
    }
}