using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Interfaces
{
    public interface IAccount
    {
        double InterestRate { get; set; }

        void Deposit(decimal amount);
        double GetInterestAmount();

    }
}
