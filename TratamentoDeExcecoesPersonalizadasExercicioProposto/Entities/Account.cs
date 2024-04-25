using System.Globalization;
using TratamentoDeExcecoesPersonalizadasExercicio.Entities.Exceptions;

namespace TratamentoDeExcecoesPersonalizadasExercicio.Entities
{
    internal class Account
    {
        // Propriedades
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // Construtores
        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Métodos
        public void Deposit(double amount)
        {
            Balance += amount;
        } // Deposica na conta

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw erro: The amount exceeds withdraw limit"); // Lança uma exceção personalizada
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance"); // Lança uma exceção personalizada
            }

            Balance -= amount;
        }
        // Efetua o saque se a quantia de saque for menor que o saldo É menor que o limete de saque.

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}