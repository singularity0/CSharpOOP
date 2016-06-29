using System;


namespace BankAccount
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer someCustomer) : base(someCustomer)
        {
        }

        public override double GetInterestAmount()
        {
            var correctionYear = DateTime.Now.Year - this.JoinDate.Year;
            double interestFirst12monthsIndividuals = this.InterestRate / 2 * 12;
            Console.WriteLine(this.AccountOwner.CustomerType == Customer.CustType.Company);
            if (this.AccountOwner.CustomerType == Customer.CustType.Individual)
            {
                
                return MortgageSpecific(correctionYear, interestFirst12monthsIndividuals, 6, 1);
            }
            else if (this.AccountOwner.CustomerType == Customer.CustType.Company)
            {
                return MortgageSpecific(correctionYear, interestFirst12monthsIndividuals, 12, this.InterestRate/2);
            }
            else
            { throw new ArgumentException("unknown Customer type for mortgage account"); }
            
        }

        private double MortgageSpecific(int correctionYear, double interestFirst12monthsIndividuals, int months, double rate)
        {
            if (DateTime.Now.Month - this.JoinDate.Month > months)
            {
                return interestFirst12monthsIndividuals + rate * ((DateTime.Now.Month - this.JoinDate.Month) + correctionYear * 12) - this.InterestRate * 12;
            }
            else
            {
                return (rate * 0.5) * (DateTime.Now.Month - this.JoinDate.Month);
            }
        }
    }
}
