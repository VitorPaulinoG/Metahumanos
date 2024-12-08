namespace Metahumanos.Models.Entities;

public class Heroi : MetaHumano
{
    public string MissaoPrincipal { get; set; }
    public int Popularidade { get; set; }
    public string Moralidade { get; set; }
    
    public Heroi(string nome, string poder, string pontoFraco, 
        string missaoPrincipal, int popularidade, string moralidade) : base (nome, poder, pontoFraco)
    {
        MissaoPrincipal = missaoPrincipal;
        Popularidade = popularidade;
        Moralidade = moralidade;
    }
    public Heroi(string nome, string poder, string pontoFraco, string missaoPrincipal) 
        : this (nome, poder, pontoFraco, missaoPrincipal, 10, "Imparcial")
    {
        
    }
    
    public virtual void SalvarPessoas()
    {
        Console.WriteLine($"Pessoas estão sendo salvas por {this.Nome}");
    }

    public override void UsarPoder()
    {
        Console.WriteLine($"{this.Nome} está usando {this.Poder}");
    }
}