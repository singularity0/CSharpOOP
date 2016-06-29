using System;


namespace BankAccount
{
    public class Individual : Customer
    {
        public Individual(string ownerID, CustType custtype) : base(ownerID, CustType.Individual)
        {
        }
    }
}
