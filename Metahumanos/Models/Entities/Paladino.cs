namespace Metahumanos.Models.Entities;

public class Paladino : Heroi
{
    public int NivelDeFe { get; set; }
    public int EnergiaDivina { get; set; }

    public Paladino(string nome, string poder, string pontoFraco, 
        string missaoPrincipal, int popularidade, string moralidade, 
        int nivelDeFe, int energiaDivina)
        : base (nome, poder, pontoFraco, missaoPrincipal, popularidade, moralidade)
    {
        NivelDeFe = nivelDeFe;
        EnergiaDivina = energiaDivina;
    }
    public void InvocarBencao()
    {
        Console.WriteLine($"O paladino {this.Nome} pede a Deus para ser abençoado.");
    }

    public void SeSacrificar(string pessoa)
    {
        Console.WriteLine($"O paladino {this.Nome} vai se sacrificar para salvar {pessoa}");
    }
    
    public void SeSacrificar(List<string> pessoas)
    {
        Console.WriteLine($"O paladino {this.Nome} vai se sacrificar para salvar: {string.Join(", ", pessoas)}");
    }
}