namespace Monstros;

public abstract class MonstroBase
{
    public MonstroBase() { }

    protected MonstroBase(string nome, double xp, double dinheiro, string raca, int vida, int ataque)
    {
        Nome = nome;
        Xp = xp;
        Dinheiro = dinheiro;
        Raca = raca;
        Vida = vida;
        Ataque = ataque;
    }

    public string Nome { get; set; }
    public double Xp { get; set; }
    public double Dinheiro { get; set; }
    public string Raca { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
}