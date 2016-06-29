using System;


namespace BankAccount
{
    public class LoanAccount : Account
    {
        

        public LoanAccount(Customer someCustomer) : base(someCustomer)
        {
            
        }

        public override double GetInterestAmount()
        {
            double correctionLoanIndividuals = 3 * this.InterestRate;
            double correctionLoanCompanies = 2 * this.InterestRate;

            if (this.AccountOwner.CustomerType == Customer.CustType.Individual)
            {
                if (base.GetInterestAmount() - correctionLoanIndividuals < 0)
                {
                    return 0;
                }
                else
                {
                    return base.GetInterestAmount() - correctionLoanIndividuals;
                }
            }

            if (this.AccountOwner.CustomerType == Customer.CustType.Company)
            {
                if (base.GetInterestAmount() - correctionLoanCompanies < 0)
                {
                    return 0;
                }
                else
                {
                    return base.GetInterestAmount() - correctionLoanCompanies;
                }
            }

            return base.GetInterestAmount();

        }
    }
}
