namespace Classes;

public class Arqueiro
{
    public string NomePersonagem { get; set; }
    public int AtaquePersonagem { get; set; }
    public int VidaPersonagem { get; set; }
    public int DefesaPersonagem { get; set; }
    public int ManaPersonagem { get; set; }
    public short EscolhaClasses { get; set; }
    public string EscolhaConfirmacao { get; set; }

    public void arqueiro()
    {
        Console.WriteLine("Você escolheu o arqueiro!");
        Console.WriteLine("============================");
        Console.WriteLine("Atributos do arqueiro:");
        Console.WriteLine("Ataque: 14");
        Console.WriteLine("Vida: 80");
        Console.WriteLine("Defesa: 30");
        Console.WriteLine("Mana: 100");
        Console.WriteLine("============================");
        Console.WriteLine("Você tem certeza da sua classe?");
        Console.WriteLine("Digite: sim ou nao");
        EscolhaConfirmacao = Console.ReadLine().ToLower();

        if (EscolhaConfirmacao == "sim")
        {
            Console.WriteLine("Você confirmou sua escolha!");
        }

        if (EscolhaConfirmacao == "nao")
        {
            Console.WriteLine("Você cancelou a escolha.");
        }
    }
}