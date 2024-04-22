namespace UpCastingDownCasting.Entities
{
    internal class SavingsAccount : Account
    {
        public  Double InterestRate { get; set; }   

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) // Sobrecarga de construtor
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
