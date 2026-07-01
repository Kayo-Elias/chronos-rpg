namespace Players;

public abstract class JogadorBase
{
    public JogadorBase() { }

    protected JogadorBase(int id, string nome, string classe, int level, double dinheiro, double nivel)
    {
        Id = id;
        Nome = nome;
        Classe = classe;
        Level = level;
        Dinheiro = dinheiro;
        Nivel = nivel;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Classe { get; set; }
    public int Level { get; set; }
    public double Dinheiro { get; set; }
    public double Nivel { get; set; }

    public void NivelJogador()
    {
        Nivel = 1;
    }
}