using System;

class Program
{
    public static void Main(string[] args)
    {
        // Declarando variáveis.
        int opcao;

        // Exibindo opções para o usuário
        Console.WriteLine("1- O céu está nublado?");
        Console.WriteLine("2- O céu está ensolarado?");
        Console.Write("\n\nOpção: ");

        // Convertendo texto digitado para inteiro
        opcao = int.Parse(Console.ReadLine());

        Console.Clear();

        // IF = SE
        if (opcao == 1)
        {
            Console.WriteLine("Recomendo levar o guarda-chuva");
        }
        else // SE NÃO
        {
            Console.WriteLine("Vou pegar um bronzeado.");
        }

    }
}
