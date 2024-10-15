using System.Security.Principal;

namespace practice6;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // create an account
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Account account = new Account(name);

        // interact with user
        MainMenu(account);
    }

    void MainMenu(Account user)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an operation:\n" +
                "1. Deposit\n" +
                "2. Display account information\n" +
                "3. Exit");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                //deposit
                Console.Write("\nEnter deposit amount: ");
                double fund = double.Parse(Console.ReadLine());
                user.Deposit(fund);
            }
            else if (choise == 2)
            {
                // display info
                user.DisplayAccountInfo();
            }

            else if (choise == 3)
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
