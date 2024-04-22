using UpCastingDownCasting.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        /*UPCASTING / DOWNCASTING
            Casting da subclasse para a superclasse
            Uso comum Polimorfismo
            
            DownCasting
            Casting da superclasse para subclasse
            Palavra as
            Palavra is
            Uso Comum: Métodos que recebem parâmetros genéricos (ex .Equals() ).
        */

        Account acc = new Account(1001, "Alex", 0.0);

        BusinessAccount bacc = new BusinessAccount(1002, "Joao", 0.0, 100.0);

        //Upcasting Conversão da subclasse para superclasse

        Account acc1 = bacc;           
        Account acc2 = new BusinessAccount(1003, "Anna", 100.00, 200.00);
        Account acc3 = new SavingsAccount(1004, "Jonas", 1000.00, 0.01);

        //DownCasting Conversão da superclasse para subclasse

        BusinessAccount acc4 = (BusinessAccount)acc2; // Convertendo 

        acc4.Loan(100.0);

        if (acc4 is  BusinessAccount)
        {
            BusinessAccount acc5 = (BusinessAccount)acc3; 
            acc5.Loan(100.00);
        }


    
        
    }
}