namespace Players;

public class JogadorRepository : Jogador
{
    public void Inicializar()
    {
        jogador.Add(new Jogador(1, "Kayo", "Mago", 10, 500));
        jogador.Add(new Jogador(2, "Elias", "Guerreiro", 10, 500));
        jogador.Add(new Jogador(3, "Oliveira", "Arqueiro", 10, 500));
        jogador.Add(new Jogador(4, "Silva", "Assasino", 10, 500));
    }
}