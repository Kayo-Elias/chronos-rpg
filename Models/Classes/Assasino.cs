using Monstros;

namespace Classes;

public class Assasino : Personagem
{
 public Assasino()
    {
        Nome = "Assasino";
        Vida = 35;
        Ataque = 15;
        Mana = 40;

        Console.WriteLine("Parabens, você escolheu o assasino!");
        Console.WriteLine("Atributos do assasino:");
        Console.WriteLine($"Nome: {Nome} - Vida {Vida} - Ataque {Ataque} - Mana {Mana}");
    }
}