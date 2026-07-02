namespace Players;

public class JogadorService : Jogador
{
    public void Listar()
    {
        Console.WriteLine("Jogadores ativos:");

        foreach (var j in jogador)
        {
            Console.WriteLine($"Nome: {j.Nome} | Classe: {j.Classe} | Level {j.Level}");
        }
    }

    public bool Selecionar()
    {
        Console.WriteLine("Deseja selecionar um jogador?");
        var selecionar = Console.ReadLine()?.ToLower() ?? string.Empty;

        if (selecionar == "sim")
        {
            Console.WriteLine("Selecione o jogador pelo nome");
            var nome = Console.ReadLine() ?? string.Empty;

            jogador.FirstOrDefault(j => j.Nome == nome);
            Console.WriteLine($"Você selecionou o jogador: {nome}");

            return true;
        }

        Console.WriteLine("Seleção cancelada!");
        return false;
    }

    public bool Adicionar()
    {
        Console.WriteLine("Digite um nickname:");
        var nome = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
            return true;
        }

        if (jogador.Any(j => string.Equals(j.Nome, nome, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Este jogador já existe!");
            return true;
        }

        jogador.Add(new Jogador(nome));
        return false;
    }
}
