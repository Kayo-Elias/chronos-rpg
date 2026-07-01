namespace Players;

public class Jogadores : JogadorBase
{
    public List<Jogadores> listaJogador = new List<Jogadores>();

    public Jogadores() { }

    public Jogadores(string nome) => Nome = nome;

    public Jogadores(int id, string nome, string classe, int level)
    {
        Id = id;
        Nome = nome;
        Classe = classe;
        Level = level;
    }

    public void IniciarJogadores()
    {
        listaJogador.Add(new Jogadores(1, "Kayo", "Mago", 10));
        listaJogador.Add(new Jogadores(2, "Elias", "Guerreiro", 10));
        listaJogador.Add(new Jogadores(3, "Oliveira", "Arqueiro", 10));
        listaJogador.Add(new Jogadores(4, "Silva", "Assasino", 10));
    }

    public void ListarJogadores()
    {
        Console.WriteLine("Jogadores ativos:");

        foreach (var j in listaJogador)
        {
            Console.WriteLine($"Nome: {j.Nome} | Classe: {j.Classe} | Level {j.Level}");
        }
    }

    public bool SelecionarJogador()
    {
        Console.WriteLine("Deseja selecionar um jogador?");
        var selecionar = Console.ReadLine().ToLower();

        if (selecionar == "sim")
        {
            Console.WriteLine("Selecione o jogador pelo nome");
            var nome = Console.ReadLine();

            listaJogador.FirstOrDefault(j => j.Nome == nome);
            Console.WriteLine($"Você selecionou o jogador: {nome}");

            return true;
        }
        else
        {
            Console.WriteLine("Seleção cancelada!");

            return false;
        }
    }

    public bool AdicionarJogador()
    {
        Console.WriteLine("Digite um nickname:");
        var nome = Console.ReadLine();

        {
            if (listaJogador.Any(j => j.Nome == nome))
            {
                Console.WriteLine("Este jogador já existe!");

                return true;
            }
            else
            {
                listaJogador.Add(new Jogadores(nome));

                return false;
            }
        }
    }
}