namespace Metahumanos.Models.Interfaces;

public interface IMafioso
{
    void FormarGangue(List<string> membros);

    void PlanejarOperacao(string operacao);

    void RecrutarMembro(string membro);
}