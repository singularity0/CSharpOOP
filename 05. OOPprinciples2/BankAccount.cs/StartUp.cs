using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class StartUp
    {
        static void Main()
        {
            var bank = new Bank("South West Bank");
            Console.WriteLine(bank.Name);

            Account someIndividualAccount = new Account(new Customer("EGN12345", Customer.CustType.Individual));
            var someCompanyAccount = new DepositAccount(new Customer("Bulstat10111122", Customer.CustType.Company));
            MortgageAccount someCMortgageAccount = new MortgageAccount(new Customer("Bulstat10111122", Customer.CustType.Company));

            //Console.WriteLine(someIndividualAccount.JoinDate);

            //setting some attributes to the individual account
            someIndividualAccount.JoinDate = new DateTime(2015, 1, 1);  
            someIndividualAccount.InterestRate = 0.003;
            someIndividualAccount.Deposit(230);
            //Console.WriteLine(someIndividualAccount.Balance);

            //setting some attributes to the company account
            someCompanyAccount.JoinDate = new DateTime(2015, 1, 1);
            someCompanyAccount.InterestRate = 0.003;
            someCompanyAccount.Deposit(230);
            //Console.WriteLine(someCompanyAccount.Balance);

            //setting some attributes to the mortgage account
            someCMortgageAccount.JoinDate = new DateTime(2015, 1, 1);
            someCMortgageAccount.InterestRate = 0.003;
            someCMortgageAccount.Deposit(230);
            //Console.WriteLine(someCMortgageAccount.Balance);

            List<Account> accList = new List<Account>() { someCompanyAccount, someIndividualAccount , someCMortgageAccount };

            foreach (var item in accList)
            {
                double amount = item.GetInterestAmount();
                Console.WriteLine(amount);
            }

        }
    }
}
