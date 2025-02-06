using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusList.Shared.Modelos.Entidades;

public class Tarefas
{
    public int IdTarefa { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string? Status { get; set; }
    public int? IdAmbiente { get; set; }
    public int? UsuarioId { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string? Icone { get; set; }

    public void ExibirTarefa()
    {
        Console.WriteLine($"Nome: {Nome}" +
            $"Descrição: {Descricao}" +
            $"Status: {Status}" +
            $"Data inicio: {DataInicio}" +
            $"Data fim: {DataFim}" +
            $"Icone: {Icone}");
    }
}



