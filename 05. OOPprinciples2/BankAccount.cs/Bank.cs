using System;


namespace BankAccount
{
    public sealed class Bank    //no bank atributes should be inheritedin our bank system, but creating other branches of the bank is allowed
    {
        public string Name { get ; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }
    }
}
