using System;


namespace BankAccount
{
    public class Company : Customer
    {
        public Company(string ownerID, CustType custType) : base(ownerID, CustType.Company)
        {
        }
    }
}
