using System.Globalization;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Exercicio Estrutura Sequencial:
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago
            Exemplos:
            Entrada:
            12 1 5.30
            16 2 5.10
            13 2 15.30
            161 4 5.20
            1 1 15.10
            2 1 15.10

            Saída:
            VALOR A PAGAR: R$ 15.50
            VALOR A PAGAR: R$ 51.40
            VALOR A PAGAR: R$ 30.20
        */

        Console.WriteLine("Entrada: ");
        string[] vetor = Console.ReadLine().Split(" ");

        float c1 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
        float n1 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
        float v1 = float.Parse(vetor[2], CultureInfo.InvariantCulture);

        vetor = Console.ReadLine().Split(" ");

        float c2 = float.Parse(vetor[0], CultureInfo.InvariantCulture);
        float n2 = float.Parse(vetor[1], CultureInfo.InvariantCulture);
        float v2 = float.Parse(vetor[2], CultureInfo.InvariantCulture);

        float total = (n1 * v1 ) + (n2 * v2);

        Console.WriteLine("Saída:");
        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}