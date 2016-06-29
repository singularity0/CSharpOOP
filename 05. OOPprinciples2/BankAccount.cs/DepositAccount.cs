using System;

namespace BankAccount
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer someCustomer) : base(someCustomer)
        {
        }

        public override double GetInterestAmount()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            return base.GetInterestAmount();
        }
    }
}
