namespace Classes;
public class Guerreiro
{
    public string NomePersonagem { get; set; }
    public int AtaquePersonagem { get; set; }
    public int VidaPersonagem { get; set; }
    public int DefesaPersonagem { get; set; }
    public int ManaPersonagem { get; set; }
    public short EscolhaClasses { get; set; }
    public string EscolhaConfirmacao { get; set; }

    public void guerreiro()
    {
        Console.WriteLine("Você escolheu o guerreiro!");
        Console.WriteLine("============================");
        Console.WriteLine("Atributos do guerreiro:");
        Console.WriteLine("Ataque: 16");
        Console.WriteLine("Vida: 85");
        Console.WriteLine("Defesa: 38");
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