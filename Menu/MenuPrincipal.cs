using Classes;

namespace Menu;

public class Menu : MenuBase
{
    public void ExibirEscolhaNick()
    {
        Console.WriteLine("Digite seu nick:");
        Console.ReadLine();
    }

    public void ExibirEscolha()
    {
        Console.WriteLine("Chronos rpg");

        Console.WriteLine("Escolha sua classe,");

        Console.WriteLine("1 - Mago");
        Console.WriteLine("2 - Guerreiro");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine("4 - Assasino");
        short.Parse(Console.ReadLine());
    }

    public void EscolherClasse(short escolha)
    {
        switch (escolha)
        {
        
        }
    }
}