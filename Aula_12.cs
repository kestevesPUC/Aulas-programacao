
using System.Transactions;

class Aula_10
{

    public static int Menu()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("|     $$ BET JKK $$     |");
        Console.WriteLine("=========================");
        Console.WriteLine("|1. Mostrar saldo       |");
        Console.WriteLine("|2. Jogar               |");
        Console.WriteLine("|3. Depositar           |");
        Console.WriteLine("|4. Sair                |");
        Console.WriteLine("=========================");

        Console.Write("\nOpção desejada: ");
        int opcao = int.Parse(Console.ReadLine());

        return opcao;
    }

    public static double Depositar(double saldo)
    {
        Console.WriteLine("Informe o valor do depósito");
        double valor = double.Parse(Console.ReadLine());
        saldo = valor + saldo;

        return saldo;
    }
    public static void Main(string[] args)
    {

        //Bet JKK

        // Roleta 2 cores
        // Saldo
        // Menu

        // Souber quantos elementos estamos tratando
        bool controle = true;
        double saldo = 100;
        Random random = new Random();


        while (controle)
        {

            int opcao = Menu();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"O seu saldo é de R${saldo}");
                    break;

                case 2:
                    if (saldo <= 0)
                    {
                        System.Console.WriteLine("Saldo insuficiente para jogar.");
                    }
                    else
                    {
                        Console.Write("Informe o valor da aposta: ");
                        double valorAposta = double.Parse(Console.ReadLine());

                        if (saldo >= valorAposta)
                        {
                            saldo = saldo - valorAposta;

                            Console.WriteLine("==========================");
                            Console.WriteLine("| Escolha a cor premiada |");
                            Console.WriteLine("==========================");
                            Console.WriteLine("| 1. Preto               |");
                            Console.WriteLine("| 2. Vermelho            |");
                            Console.WriteLine("==========================");

                            int corEscolhida = int.Parse(Console.ReadLine());
                            int numeroAleatorio = random.Next();

                            // A COR PRETA É PAR 
                            if (numeroAleatorio % 2 == 0)
                            {
                                Console.WriteLine($"A cor premiada foi o 'Preto'");
                                if (corEscolhida == 1)
                                {
                                    saldo = saldo + (valorAposta * 2);
                                    System.Console.WriteLine($"Parabéns, você ganhou R${valorAposta}! Novo saldo R${saldo}");
                                }
                                else
                                {
                                    Console.WriteLine($"Você perdeu! Seu saldo é de R${saldo}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"A cor premiada foi o 'Vermelho'");
                                // A COR IMPAR É VERMELHO
                                if (corEscolhida == 2)
                                {
                                    saldo = saldo + (valorAposta * 2);
                                    System.Console.WriteLine($"Parabéns, você ganhou R${valorAposta}! Novo saldo R${saldo}");
                                }
                                else
                                {
                                    Console.WriteLine($"Você perdeu! Seu saldo é de R${saldo}");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Saldo insuficiente. Seu saldo é de R${saldo}");
                        }
                    }
                    break;

                case 3:
                    saldo = Depositar(saldo);
                    System.Console.WriteLine($"Depósito realizado com sucesso! Seu saldo é de {saldo}");
                    break;

                case 4:

                    controle = false;
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }


        }

        Console.WriteLine("Obrigado por jogar! Volte sempre.");

    }
}

