namespace assignment2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        while (true)
        {
            Console.Write("Enter a positive integer: ");
            int integer = int.Parse(Console.ReadLine());
            if (integer == 0)
            {
                Console.WriteLine("\nend of program");
                return;
            }
            else if (integer > 0)
            {
                int primeFactors = CountPrimeFactors(integer);
                if (primeFactors == 1)
                {
                    Console.WriteLine($"The number {integer} is a prime number!\n");
                }
                else
                {
                    Console.WriteLine($"The number {integer} has {primeFactors} prime factors.\n");
                }
            }
        }
    }

    int CountPrimeFactors(int number)
    {
        int divisor = 2;
        int counter = 0;

        while (number > 1)
        {
            if (number % divisor == 0)
            {
                counter++;
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }
        return counter;
    }
}

