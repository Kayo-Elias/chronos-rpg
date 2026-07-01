using Monstros;

namespace Classes;

public class Mago : Personagem
{
    public Mago()
    {
        Nome = "Mago";
        Vida = 35;
        Ataque = 12;
        Mana = 30;

        Console.WriteLine("Parabens, você escolheu o mago!");
        Console.WriteLine("Atributos do mago:");
        Console.WriteLine($"Nome: {Nome} - Vida {Vida} - Ataque {Ataque} - Mana {Mana}");
    }
}