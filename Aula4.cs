using System;

class Program
{
    public static void Main(string[] args)
    {

        // Calculando a média dos salários.
        // int[] vetor = new int[5];
        int[] salarios = { 5000, 10000, 10000, 30000, 500 };

        double soma = 0;
        double media;

        for (int i = 0; i < 5; i++)
        {
            soma = soma + salarios[i];
        }

        media = soma / 5;

        Console.WriteLine($"A média salarial dos funcionários é {media}");
    }
}
