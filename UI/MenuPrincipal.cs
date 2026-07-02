using Classes;
using Players;

namespace Menu;

public class MenuPrincipal
{
    JogadorRepository jogadorRepository = new JogadorRepository();
    JogadorService jogadorService = new JogadorService();

    public void SelecionarOuCriarJogador()
    {
        Console.WriteLine("===================");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("===================");

        Console.WriteLine("1 - Escolher um jogador existente");
        Console.WriteLine("2 - Criar novo jogador");
        var escolha = short.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                jogadorRepository.Inicializar();
                jogadorService.Listar();
                jogadorService.Selecionar();
                break;

            case 2:
                jogadorService.Adicionar();
                jogadorRepository.Inicializar();
                jogadorService.Listar();
                break;

            default:
                throw new ArgumentException("Opção invalida!");
        }
    }

    public Personagem EscolherClasse()
    {
        Console.WriteLine("CHRONOS RPG");

        Console.WriteLine($"Escolha sua classe");

        Console.WriteLine("1 - Mago");
        Console.WriteLine("2 - Guerreiro");
        Console.WriteLine("3 - Arqueiro");
        Console.WriteLine("4 - Assasino");
        
        short escolhaClasse = short.Parse(Console.ReadLine());

        Personagem personagem = EscolherClasse();

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