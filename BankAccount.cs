using System;
using classes;

namespace classes
{

    public class BankAccount
    {
        public Client Client { get;}
        
        public decimal Balance { get; set; }
        
        public string Type { get; set; }
      

        public BankAccount(string Name, string Type)
        {
            this.Client = Client;
            this.Balance = 0;
            this.Type = Type;
        }

        public decimal CheckBalance()
        {
            return this.Balance;
        }

        public bool Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount > this.Balance)
            {
                this.Balance -= withdrawAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(decimal DepAmount)
        {
            this.Balance += DepAmount;

        }
    }
}


       