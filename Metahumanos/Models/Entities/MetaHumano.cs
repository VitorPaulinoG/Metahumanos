namespace Metahumanos.Models.Entities;

public abstract class MetaHumano
{
    public string Nome { get; private set; }
    public string Poder { get; private set; }
    public string PontoFraco { get; private set; }

    public MetaHumano(string nome, string poder, string pontoFraco)
    {
        Nome = nome;
        Poder = poder;
        PontoFraco = pontoFraco;
    }
    
    public abstract void UsarPoder();
}