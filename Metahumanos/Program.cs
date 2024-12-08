using Metahumanos.Models.Entities;

Heroi heroi = new Heroi("Superman", "Força sobre-humana, visão de calor", 
    "Kryptonite", "Proteger a Terra");

Paladino paladino = new Paladino("Thor", "Martelo Mjolnir", 
    "Vingança e orgulho", "Proteger Asgard", 
    100, "Nobre", 10, 100);

AntiHeroi antiHeroi = new AntiHeroi("Deadpool", 
    "Regeneração acelerada e habilidades de combate", "Coração", 
    "Vingança pessoal", 50, "Pragmático", 60)
{
    PessoasProtegidas = "Wade Wilson (ele mesmo), Vanessa Carlysle"
};

Vilao vilao = new Vilao("Loki", "Magia e ilusão", 
    "Falta de confiança", "Conquistar Asgard");


PrintWithColor($"Heroi {heroi.Nome}: ", 6, heroi.Nome.Length, ConsoleColor.Red);
heroi.SalvarPessoas();
heroi.UsarPoder();

PrintWithColor($"Paladino {paladino.Nome}: ", 9, paladino.Nome.Length, ConsoleColor.Red);
paladino.InvocarBencao();
paladino.SeSacrificar("Jane Foster");
paladino.SeSacrificar(["Jane Foster", "Sif", "Heimdall" ]);

PrintWithColor($"Anti-heroi {antiHeroi.Nome}: ", 11, antiHeroi.Nome.Length, ConsoleColor.Red);
antiHeroi.SalvarPessoas();
antiHeroi.AtaqueFurtivo();
antiHeroi.Radicalizar();
antiHeroi.IgnorarLeis(new List<string> { "Propriedade privada", "Segurança pública" });
antiHeroi.Blefar();


PrintWithColor($"Vilão {vilao.Nome}: ", 6, vilao.Nome.Length, ConsoleColor.Red);
vilao.AtacarCidade("Nova York");
vilao.UsarPoder();
vilao.IgnorarLeis(new List<string> { "Impostos", "Propriedade intelectual" });
vilao.Radicalizar();
vilao.FormarGangue();


Console.WriteLine("\nDesafios e ações:");
antiHeroi.DesafiarAutoridade("S.H.I.E.L.D.");
vilao.IgnorarLeis(new List<string> { "Lei anti-violência", "Lei de imigração" });


void PrintWithColor(string text, int index, int length, ConsoleColor color)
{
    Console.Write(text.Substring(0, index));
    Console.ForegroundColor = color;
    Console.Write(text.Substring(index, length));
    Console.ResetColor();
    Console.WriteLine(text.Substring(index+length, text.Length - (index + length)));
}