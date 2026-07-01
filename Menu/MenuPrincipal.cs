using Classes;
using Players;

namespace Menu;

public class MenuPrincipal
{
    Jogadores gerenciarJogadores = new Jogadores();

    public void SelecionarOuCriarJogador()
    {
        Console.WriteLine("=====BEM-VINDO====");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("===================");

        Console.WriteLine("1 - Escolher um jogador existente");
        Console.WriteLine("2 - Criar novo jogador");
        var escolha = short.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                gerenciarJogadores.IniciarJogadores();
                gerenciarJogadores.ListarJogadores();
                gerenciarJogadores.SelecionarJogador();
                break;

            case 2:
                gerenciarJogadores.IniciarJogadores();
                gerenciarJogadores.ListarJogadores();
                gerenciarJogadores.AdicionarJogador();
                break;
        }
    }

    public Personagem EscolherClasse(short escolhaClasse)
    {
        Console.WriteLine("====CHRONOS RPG=====");

        Console.WriteLine($"Escolha sua classe");

        Console.WriteLine("1 - Mago");
        Console.WriteLine("2 - Guerreiro");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine("4 - Assasino");
        short escolha = short.Parse(Console.ReadLine());

        Personagem personagem = EscolherClasse(escolha);

        switch (escolhaClasse)
        {
            case 1:
                return new Mago();

            case 2:
                return new Guerreiro();

            case 3:
                return new Arqueiro();

            case 4:
                return new Assasino();

            default:
                throw new ArgumentException("Classe invalida");
        }
    }
}