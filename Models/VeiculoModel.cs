using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeiculosMVC.Models
{
    public class VeiculoModel
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public decimal PrecoPorDia { get; set; }
    public string FotoUrl { get; set; }
    public bool Disponivel { get; set; } = true;
}
}