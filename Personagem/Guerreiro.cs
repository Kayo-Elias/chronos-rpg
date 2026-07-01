using Monstros;

namespace Classes;

public class Guerreiro : Personagem
{
    public Guerreiro()
    {
        Nome = "Guerreiro";
        Vida = 45;
        Ataque = 16;
        Mana = 20;

        Console.WriteLine("Parabens, você escolheu o guerreiro!");
        Console.WriteLine("Atributos do guerreiro:");
        Console.WriteLine($"Nome: {Nome} - Vida {Vida} - Ataque {Ataque} - Mana {Mana}");
    }
}