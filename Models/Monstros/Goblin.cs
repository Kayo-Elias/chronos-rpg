using Classes;
using Players;

namespace Monstros;

public class Goblin : MonstroBase
{
    public Goblin()
    {
        Nome = "Goblin";
        Raca = "Goblinus";
        Dinheiro = 5;
        Xp = 10;
        Vida = 20;
        Ataque = 12;
        Xp = 10;
    }

    public void Atacar(Personagem alvo)
    {
        alvo.Vida -= Ataque;

        Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {Ataque} de dano.");
    }

    public void VerificarMorto(Jogador jogador)
    {
        if (Vida <= 0)
        {
            Console.WriteLine("você matou o Goblin.");
            jogador.Nivel += Xp;
        }
    }
}