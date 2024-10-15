using System;
namespace practice6
{
	public class Account
	{
		//fields
		private string _accountholder;
		private double _amount = 0;

        // constructor
        public Account(string accountHolder)
		{
			this._accountholder = accountHolder;
		}

		// methods
		public void Deposit(double amount)
		{
            _amount += amount;
			LogTransaction("Deposit successful.");
        }

        private void LogTransaction(string message)
		{
			Console.WriteLine(message);
		}

        public void DisplayAccountInfo()
		{
			Console.WriteLine($"\nAccount holder: {_accountholder}");
			Console.WriteLine($"Balance: {_amount}");
		}
    }
}

