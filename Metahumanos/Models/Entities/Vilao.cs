using Metahumanos.Models.Interfaces;

namespace Metahumanos.Models.Entities;

public class Vilao : MetaHumano, IRebelde, IMafioso
{
    public string Motivacao { get; set; }

    public Vilao(string nome, string poder, string pontoFraco, string motivacao) 
        : base(nome, poder, pontoFraco)
    {
        Motivacao = motivacao;
    }

    public void AtacarCidade(string cidade)
    {
        Console.WriteLine($"{this.Nome} está atacando a {cidade}.");
    }


    public override void UsarPoder()
    {
        Console.WriteLine($"{this.Nome} está atacando civis com {this.Poder}");
    }
        

    public void IgnorarLeis(List<string> leis)
    {
        Console.WriteLine($"{this.Nome} está ignorando as seguintes leis: "
            + string.Join(", ", leis));
    }

    public void Radicalizar()
    {
        Console.WriteLine($"O vilão {this.Nome} está indo contra tudo e todos.");
        Console.WriteLine($"Ele está prestes a meter o terror em toda a cidade, sequestrando pessoas, torturando autoridades e até assassinando herois.");
    }

    public void FormarGangue()
    {
        Console.WriteLine($"O vilão {this.Nome} formou uma gangue com seus capangas para aterrorizar os civis.");
    }
}