using System;
using classes;


namespace Bank_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Printer! What would you like to do sir/madam?");
            Console.WriteLine("1. Check, 2. Deposite , 3. Withdraw , 4. Exit");

            var choice = Console.ReadLine();

            Client Client = new Client("name");
            BankAccount BankAccount = new BankAccount("Client", "Type");
            
            switch (choice)
            {
                case "1" :
                    {
                        Console.WriteLine("Your currently balance is " + BankAccount.CheckBalance() + " euro");
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("How much would you like to deposite?");
                        var DepAmount = decimal.Parse(Console.ReadLine());
                        BankAccount.Deposit(DepAmount);
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine("How much would you like to withdraw? ");
                        var withdrawAmount = decimal.Parse(Console.ReadLine());
                        BankAccount.Withdraw(withdrawAmount);
                        break;
                    }

                case "4":
                    {
                        Console.WriteLine("Thank you, Have a nice day");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Please, choose again");
                        break;
                    }
            }
        }

    }
}

