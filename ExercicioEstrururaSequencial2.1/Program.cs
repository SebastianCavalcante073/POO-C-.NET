using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Exercicio Estrutura Sequencial Exercício 2.1
            Com base na tabela de preços a baixo, faça um programa que leia o código de um item e a quantidade deste item.
            A seguir, calcule e mostre o valor da conta a pagar.

            Tabela:
            1 Cachorro Quente  R$ 4.00
            2 X - Salada       R$ 4.50
            3 X - Bacon        R$ 5.00
            4 Torrada Simples  R$ 2.00
            5 Regrigerante     R$ 1.50

        Exemplo de entradas:
        3 2  
        2 3 

        Exemplo de saídas:
        Total: R$ 10.00
        Total: R$ 13.50
       
        */

        string[] vet = Console.ReadLine().Split(" ");

        int cod = int.Parse(vet[0]);
        double quantity = double.Parse(vet[1]);

        double totalPrice = 0;

        switch (cod)
        {
            case 1:
                totalPrice = quantity * 4.0f;
                break;
            case 2:
                totalPrice = quantity * 4.50f;
                break;
            case 3:
                totalPrice = quantity * 5.00f;
                break;
            case 4:
                totalPrice = quantity * 2.00f;
                break;
            case 5:
                totalPrice = quantity * 1.50f;
                break;
        }

        Console.WriteLine($"Total: R$ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}