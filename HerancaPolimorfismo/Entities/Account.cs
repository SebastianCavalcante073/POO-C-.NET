using System.Globalization;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    internal class Account
    {
        //Propriedades
        public int Number { get; protected set; }
        public  string Holder { get; protected set; }
        public double  Balance { get; protected set; }

        //Construtores
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Métodos
        public void WithDraw(double amount)
        {
            Balance -= amount;
        } // Realiza um saque da conta a partir da quantia informada

        public void Deposit(double amount)
        {
            Balance += amount;
        } // Realiza um deposito na conta a partir da quantida informada

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Account");
            sb.AppendLine("Number: " + Number.ToString());
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();
        } // Saída de dados
    }
}