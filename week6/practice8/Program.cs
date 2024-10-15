namespace practice8;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // create an account
        Console.Write("Enter account number: ");
        string name = Console.ReadLine();

        BankAccount account = new BankAccount(name, 0);

        // interact with user
        MainMenu(account);
    }

    void MainMenu(BankAccount user)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an operation:\n" +
                "1. Deposit\n" +
                "2. Withdrawal\n" +
                "3. Display account information\n" +
                "4. Exit");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                //deposit
                Console.Write("\nEnter deposit amount: ");
                double amount = double.Parse(Console.ReadLine());
                user.Deposit(amount);
            }

            else if (choise == 2)
            {
                // withdraw
                Console.Write("\nEnter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());
                user.Withdraw(amount);
            }
            else if (choise == 3)
            {
                // display info
                user.DisplayAccountInfo();
            }

            else if (choise == 4)
            {
                Console.WriteLine("\nSession is finished.");
                break;
            }

            else
            {
                Console.WriteLine("Error: unexpected input.");
            }
        }
    }
}



