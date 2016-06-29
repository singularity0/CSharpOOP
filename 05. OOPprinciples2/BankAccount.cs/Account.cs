using BankAccount.Interfaces;
using System;


namespace BankAccount
{
    public class Account : ICustomers, IAccount
    {
        private decimal balance;
        private Customer acountOwner;

        public decimal Balance { get { return this.balance; } protected set { this.balance = value; } }
        public Customer AccountOwner { get { return this.acountOwner; } set { this.acountOwner = value; } }
       

        public double InterestRate { get; set; }
        
        public DateTime JoinDate {get; set;}

        public Account(Customer someCustomer)
        {
            this.AccountOwner = someCustomer;
            this.JoinDate = DateTime.Now;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public virtual double GetInterestAmount()
        {
            var correctionYear = DateTime.Now.Year - this.JoinDate.Year;
            return (double)this.Balance * this.InterestRate * (double)((DateTime.Now.Month - this.JoinDate.Month)+correctionYear*12) ;
        }
    }
}
