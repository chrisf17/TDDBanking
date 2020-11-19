using System;
namespace Banking.Lib
{
    public class CurrentAccount: Account
    {
        decimal overdraft;
        public CurrentAccount(decimal overdraft)
        {
            this.overdraft = overdraft;
        }

        public override void Withdraw(decimal amount)
        {
            if (this.Balance + this.overdraft - amount >= 0)
            {
                base.Withdraw(amount);
            }
            else
            {
                throw new AccountOverdrawnException();
            }
        }

    }
}
