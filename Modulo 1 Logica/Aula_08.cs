using System;
using System.Runtime.InteropServices;

class Aula_08
{

    static void Main(string[] args)
    {
        /** Você deverá criar um vetor de inteiros que o usuário ira informar o tamanho,
        *  popular o vetor e deverá mostrar ao final quantos números são pares e quantos são ímpares
        *  mostre qual o maior e o menor valor dentro do array
        */

        // Declarando variáveis
        int tamanho;
        int maior = 0;
        int menor = 0;
        int pares = 0;
        int impares = 0;

        // Declarando vetor
        int[] numeros;

        Console.Write("Informe a quantidade de números: ");
        tamanho = int.Parse(Console.ReadLine());

        // Instanciando Vetor
        numeros = new int[tamanho];

        
        Console.WriteLine("Informe os números ");

        // Populando o vetor
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"{i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Se o resto da divisão por 2 for 0 é par
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }

            // Guarda o valor do maior número
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            else if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        impares = tamanho - pares;

        Console.WriteLine($"O vetor tem {tamanho} posições, {pares} são pares e {impares} ímpares. O maior número é o {maior} e o menor é o {menor}");
    }
}
