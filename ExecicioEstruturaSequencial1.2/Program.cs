using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Exercicio Estrutura Sequencial Calculando a area de um circulo:
            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            casas decimais conforme exemplos.
            Fórmula: area = pi * raio²
            Considere o valor de pi = 3.14159
            
            Exemplos:
            Entrada:
            2.00
            100.64
            150.00

            Saída:
            A=12.5664
            A=31819.3103
            A=70685.7750
        */

        float raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float pi = 3.14159f;
        float area = pi * raio * raio;

        Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}