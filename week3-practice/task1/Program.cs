namespace task1;

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
            Console.Write("Enter a positive integer: ");
            input = int.Parse(Console.ReadLine()); 
        } while (input < 1);

        Console.WriteLine($"The sum of natural numbers from 1 to {input} is: " +
            $"{CalculateSum(input)}");
    }

    int CalculateSum(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            result += i;
        }
        return result;
    }
}