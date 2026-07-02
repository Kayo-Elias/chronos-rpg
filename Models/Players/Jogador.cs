namespace Players;

public class Jogador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Classe { get; set; }
    public int Level { get; set; }
    public double Dinheiro { get; set; }
    public double Nivel { get; set; }
    public static List<Jogador> jogador { get; } = new List<Jogador>();

    public Jogador() { }

     public Jogador(string nome) => Nome = nome;

    public Jogador(int id, string nome, string classe, int level, double dinheiro)
    {
        Id = id;
        Nome = nome;
        Classe = classe;
        Level = level;
        Dinheiro = dinheiro;
    }
}