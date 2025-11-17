public class Aula_13
{
    public static void Main(string[] args)
    {
        // MEGA SENA PREMIADA.

        // GERAR UMA SEQUENCIA DE 6 NUMEROS ALEATORIOS ENTRE 1 E 60.
        // NAO PODER TER NUMEROS REPETIDOS

        Random random = new Random();
        bool controle = true;
        int[] numerosSorteados = new int[6];
        string sequencia = "";
        int contador = 0;

        while (controle)
        {
            bool existe = false;
            int numero = random.Next(1, 61);

            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                if (numerosSorteados[i] == numero)
                {
                    existe = true;
                }
            }

            if (!existe)
            {
                numerosSorteados[contador] = numero;
            } else
            {
                contador--;
            }

            if (contador == 5)
            {
                controle = false;
            }

            contador++;
        }

        for (int i = 0; i < numerosSorteados.Length; i++)
        {
            if (sequencia == "")
            {
                sequencia = $"{numerosSorteados[i]}";
            }
            else
            {
                sequencia = sequencia + $", {numerosSorteados[i]}";
            }
        }
        
        Console.WriteLine($"A sequencia premiada e {sequencia}");
    }
}