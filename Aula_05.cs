using System;

class Aula_05
{
    static void Main(string[] args)
    {
        /**
        Para Casa para 16/09: Analisando Notas da Turma

            Você deve escrever um programa que:
                1.	Crie um vetor para armazenar as notas de 5 alunos.
                2.	Peça ao usuário que digite cada nota e armazene no vetor.
                3.	Use um loop (for) para:
                •	Exibir todas as notas digitadas.
                •	Calcular a média da turma.
                4.	Ao final, mostre:
                •	Todas as notas digitadas.
                •	A média da turma.
                •	Quantos alunos ficaram acima da média. Média é acima de 60.
        */

        int[] notas = new int[5];

        System.Console.WriteLine("Digite as notas de 5 alunos:");

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"Nota do aluno {i + 1}:");
            notas[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("Nota do aluno " + (i + 1) + ": " + notas[i]);
        }

    }
}
