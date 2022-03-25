using Desafio.Entities.Exceptions;

namespace Desafio.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account ()
        {

        }

        public Account (int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Deposit error: Trying to deposit a negative/zero amount");
            }

            Balance += amount;
        }

        public void Withdraw (double amount)
        {
            if (Balance <= 0 || Balance < amount)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
