using System;
namespace Banking.Lib
{
    public class SavingsAccount: Account
    {
        public SavingsAccount()
        {
        }
        public override void Withdraw(decimal amount)
        {
            if (this.Balance - amount >= 0)
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
