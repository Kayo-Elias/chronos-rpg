public class Aranha
{
    public string NomeMonstro { get; set; }
    public double VidaMonstro { get; set; }
    public double AtaqueMonstro { get; set; }
    public double DefesaMonstro { get; set; }

    public Aranha(string nome, double vida, double ataque, double defesa)
    {
        NomeMonstro = nome;
        VidaMonstro = vida;
        AtaqueMonstro = ataque;
        DefesaMonstro = defesa;
    }

    public Aranha()
    {
        NomeMonstro = "Aranha";
        VidaMonstro = 30;
        AtaqueMonstro = 10;
        DefesaMonstro = 15;
    }
}