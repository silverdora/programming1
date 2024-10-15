using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace practice8
{
    public class BankAccount
	{

        //properties
        public string AccountNumber { get; }
        public double Balance { get; set; }

        //constructor
        public BankAccount(string accountNumber, double initialBalance)
		{
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
		}

        //methods
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("The money in your account is not enough for " +
                    "this payment. Check the balance and try again.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"\nAccount Details:\n" +
                $"Account Number: {AccountNumber}\n" +
                $"Balance: {Balance:0.00}");
        }
    }
}

