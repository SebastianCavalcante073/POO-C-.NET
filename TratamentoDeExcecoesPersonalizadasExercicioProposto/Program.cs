using System.Globalization;
using TratamentoDeExcecoesPersonalizadasExercicio.Entities;
using TratamentoDeExcecoesPersonalizadasExercicio.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit); // Instância um objeto do tipo account

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account.Withdraw(amount); // Efetua o saque de acordo com a quantia informada

            Console.WriteLine(account.ToString());
        }
        catch (DomainException e) // Lança uma exceção caso o saque não seja possivel.
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e) // Lança uma exceção generica para as demais exceções.
        {
            Console.WriteLine("Other Exception: " + e.Message);
        }
    }
}