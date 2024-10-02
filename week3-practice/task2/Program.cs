namespace task2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int input = 0;
        do
        {
            Console.Write("Enter a non-negative integer: ");
            input = int.Parse(Console.ReadLine());
        } while (input < 1);

        Console.WriteLine($"The factorial of {input} is: " +
            $"{CalculateFactorial(input)}");
    }

    int CalculateFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

