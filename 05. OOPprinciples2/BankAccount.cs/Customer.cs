using BankAccount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount

{
    public class Customer
    {

        private string accountOwner;
        private CustType customerType;

        public string AccountOwner { get { return this.accountOwner; } set { this.accountOwner = value; } }
        public CustType CustomerType { get { return this.customerType; } set { this.customerType = value; } }



        public Customer(string ownerID, CustType custType)
        {
            this.AccountOwner = ownerID;
            this.CustomerType = custType;
        }

        public enum CustType{
            Company , Individual
        }
    }
}
