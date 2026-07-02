using Monstros;

namespace Classes;

public class Arqueiro : Personagem
{
     public Arqueiro()
    {
        Nome = "Arqueiro";
        Vida = 45;
        Ataque = 14;
        Mana = 25;

        Console.WriteLine("Parabens, você escolheu o arqueiro!");
        Console.WriteLine("Atributos do arqueiro:");
        Console.WriteLine($"Nome: {Nome} - Vida {Vida} - Ataque {Ataque} - Mana {Mana}");
    }
}