namespace task6;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a positive integer greater than 1: ");
        int enteredNumber = int.Parse(Console.ReadLine());

        if (enteredNumber <= 0)
        {
            Console.WriteLine($"{enteredNumber} is not a positive number.");
            return;
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
            Console.WriteLine($"{enteredNumber} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{enteredNumber} is not a prime number.");
        }
    }
}


