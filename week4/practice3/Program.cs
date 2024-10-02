namespace practice3;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] arrayOfNumbers = new int[3];
        FillArray(arrayOfNumbers);
        Console.WriteLine("\n");
        Console.WriteLine($"Sum: {CalculateSum(arrayOfNumbers)}");
        Console.WriteLine($"Average: {CalculateAverage(arrayOfNumbers):0.00}");

    }

    void FillArray(int[] numbers)
    {
        Console.WriteLine($"Enter {numbers.Length} integers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
    }

    int CalculateSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    double CalculateAverage(int[] numbers)
    {
        return (double)CalculateSum(numbers) / numbers.Length;
    }
}
