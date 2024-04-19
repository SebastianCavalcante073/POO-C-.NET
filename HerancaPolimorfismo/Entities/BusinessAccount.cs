using System.Globalization;
using System.Text;

namespace HerancaEPolimorfismo.Entities
{
    internal class BusinessAccount : Account // Classe BusinessAccount está herdandos os atributos e comportamentos da classe Account
    {
        //Propriedades
        public double LoanLimit { get; set; }

        //Construtores
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) 
        {
            LoanLimit = loanLimit;
        }

        //Métodos
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += LoanLimit;
            }
        } // Verifica e acrescenta a BusinessAccount um valor de emprestimo caso a quantia informada seja menor ou igual ao limit de crédito.
      
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BusinessAccount");
            sb.AppendLine("Number: " + Number);
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("LoanLimit: " + LoanLimit.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        } // Saída de dados
    }
}
