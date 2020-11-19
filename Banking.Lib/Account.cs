using System;

namespace Banking.Lib
{
    public abstract class Account
    {
        public class AccountOverdrawnException : ApplicationException { }
        public class MoneyLaunderingPreventionException : ApplicationException { }
        const decimal MAX_DEPOSIT = 10000m;
        decimal balance;

        public decimal Balance { get => balance; set => balance = value; }

        public virtual void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount > MAX_DEPOSIT) throw new MoneyLaunderingPreventionException();
            this.balance -= amount;
        }

    }
}
