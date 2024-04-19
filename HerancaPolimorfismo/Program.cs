using HerancaEPolimorfismo.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Account account = new Account(5401, "Fernando", 1500.00);
        BusinessAccount businessAccount = new BusinessAccount(8201, "Joao", 2000.00, 2000.00);

        Console.WriteLine(account);
        Console.WriteLine(businessAccount);
    }
}