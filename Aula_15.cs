public class Aula_15
{

    public static int Soma(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;

        return resultado;
    }


    public static int Multiplica(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;

        return resultado;
    }

    public static int Fatorial(int numero)
    {
        int resultado = 1;
        for (int i = numero; i >= 1; i--)
        {
            resultado = Multiplica(resultado, i);
        }

        return resultado;

    }


    // S0 = S1 + v*t2/2
    public static int Menu()
    {
        System.Console.WriteLine("===================");
        System.Console.WriteLine("1- Calcula Fatorial");
        System.Console.WriteLine("2- Calcular média");
        System.Console.WriteLine("===================");

        int opcao = int.Parse(Console.ReadLine());

        return opcao;
    }
    public static void Main(string[] args)
    {
        int opcao = Menu();

        switch (opcao)
        {
            case 1:
                System.Console.Write("Informe o número que deseja saber o fatorial: ");

                int valor = int.Parse(Console.ReadLine());
                int resultado = Fatorial(valor);

                System.Console.WriteLine($"O fatorial de {valor} é {resultado}.");
                break;
        }
    }
}