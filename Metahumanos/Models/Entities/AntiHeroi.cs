using Metahumanos.Models.Interfaces;

namespace Metahumanos.Models.Entities;

public class AntiHeroi : Heroi, IRebelde
{
    public int NivelDeOportunismo { get; set; }
    public string PassadoSombrio { get; set; }
    public string? PessoasProtegidas { get; set; }

    public AntiHeroi(string nome, string poder, string pontoFraco, 
        string missaoPrincipal, int popularidade, string moralidade, int nivelDeOportunismo) 
        : base  (nome, poder, pontoFraco, missaoPrincipal, popularidade, moralidade)
    {
        NivelDeOportunismo = nivelDeOportunismo;
    }
    
    public void AtaqueFurtivo()
    {
        Console.WriteLine($"Como um ninja, {this.Nome} atacará os inimigos sem que eles percebam.");
    }
    
    public void DesafiarAutoridade(string autoridade)
    {
        Console.WriteLine($"A autoridade {autoridade} foi desafiada por {this.Nome}");
    }

    public override void SalvarPessoas()
    {
        Console.WriteLine($"{this.Nome} só salva as seguintes pessoas: " +
                          $"{string.Join('\n', this.PessoasProtegidas)}");
    }

    public void Blefar()
    {
        Console.WriteLine($"{this.Nome} está blefando...");
    }

    public void IgnorarLeis(List<string> leis)
    {
        Console.WriteLine($"As leis {string.Join(", ", leis)} estão sendo ignoradas por {this.Nome} para que ele conclua seu objetivo de {this.MissaoPrincipal}");
    }

    public void Radicalizar()
    {
        Console.WriteLine($"{this.Nome} tomará atitudes extremas para cumprir seu objetivo de {this.MissaoPrincipal}");
        Console.WriteLine($"Ele poderá agir como um justiceiro.");
    }
}