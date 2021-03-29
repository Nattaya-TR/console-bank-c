using System;

namespace BankAccount
{
    class BankAccount
    {
        public string Client
        {
            get { return Client; }
            set { Client = value; }
        }
        public double Balance
        {
            get { return Balance; }
            set { Balance = value; }
        }
        public string Type
        {
            get { return Type; }
            set { Type = value; }
        }
        public BankAccount(string Client, double Balance, string type)
        {
            this.Client = Client;
            this.Balance = Balance;
            this.Type = Type;
        }

        public void CheckBalance()
        {
            //don't know yet what to do
        }

        public void Withdraw()
        {
            //
        }

        public void Deposit() 
        { 
            //
        }
    }

}
