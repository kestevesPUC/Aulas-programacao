class Aula_11
{
    // Case Switch


    public static bool VerificaSeEPar(int numero)
    {
        bool resultado;

        if (numero % 2 == 0)
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }
        
        return resultado;
    }
    public static void Main(string[] args)
    {
        int opcao;

        System.Console.WriteLine("Informe um número");
        opcao = int.Parse(Console.ReadLine());

        bool resultado = VerificaSeEPar(opcao);

        switch (opcao)
        {
            case 1:
                System.Console.WriteLine("Opção 1 selecionada");
            break;

            case 2:
                System.Console.WriteLine("Opção 2 selecionada");
                break;

            default:
                System.Console.WriteLine("Opção inválida");
                break;
        }
    }
}