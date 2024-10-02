namespace exercise2;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a number: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        bool prime = true;
        for (int i = 2; i < enteredNumber; i++)
        {
            if (enteredNumber % i == 0)
            {
                prime = false;
                Console.WriteLine($"{enteredNumber} is not prime");
                break;
            }
        }
        if (prime)
        {
            Console.WriteLine($"{enteredNumber} is prime");
        }

        bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        if (IsPrime(enteredNumber))
        {
            Console.WriteLine($"{enteredNumber} is prime");
        }
        else
        {
            Console.WriteLine($"{enteredNumber} is not prime");
        }
    }
}
