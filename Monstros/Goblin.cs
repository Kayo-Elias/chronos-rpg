using Classes;

namespace Monstros;

public class Goblin : MonstroBase
{
    public Goblin()
    {
        Nome = "Goblin";
        Raca =  "Goblinus";
        Vida = 20;
        Ataque = 12;
    }

    public void Atacar(Personagem alvo)
    {
        alvo.Vida -= Ataque;

        Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {Ataque} de dano.");
    }

    public void Defender()
    {
        
    }
}