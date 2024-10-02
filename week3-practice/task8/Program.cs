namespace task8;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter the number of elements: ");
        int count = int.Parse(Console.ReadLine());

        int sum = CalculateSum(count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {CalculateAverage(sum, count)}");
    }

    int CalculateSum(int count)
    {
        int sum = 0;
        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Enter number {i}: ");
            sum += int.Parse(Console.ReadLine());
        }
        return sum;
    }

    double CalculateAverage(int sum, int count)
    {
        return (double)sum/count;
    }
}

