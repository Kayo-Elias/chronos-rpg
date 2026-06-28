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
    }
   
    public void Atacar(Goblin alvo)
    {
        alvo.Vida -= Ataque;
    }
}