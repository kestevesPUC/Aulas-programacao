using System;
using System.Runtime.InteropServices;

class Aula_05
{

    static void Main(string[] args)
    {
        int[] notas = new int[6];
        int soma = 0;
        Console.WriteLine("Nota do aluno 1: ");
        notas[0] = int.Parse(Console.ReadLine());


        Console.WriteLine("Nota do aluno 2: ");
        notas[1] = int.Parse(Console.ReadLine());


        Console.WriteLine("Nota do aluno 3: ");
        notas[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("Nota do aluno 4: ");
        notas[3] = int.Parse(Console.ReadLine());


        Console.WriteLine("Nota do aluno 5: ");
        notas[4] = int.Parse(Console.ReadLine());


        Console.WriteLine("Nota do aluno 6: ");
        notas[5] = int.Parse(Console.ReadLine());

        System.Console.WriteLine("As notas dos alunos são:");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(notas[i]);
            soma = soma + notas[i];
        }
        Console.WriteLine($"A media da turma é: {soma / 6}");
        



    }
}
