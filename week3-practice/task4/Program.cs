namespace task4;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter the start of the range: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter the end of the range: ");
        int last = int.Parse(Console.ReadLine());

        int even = CountEvenAndOdd(first, last).evenCount;
        int odd = CountEvenAndOdd(first, last).oddCount;

        Console.WriteLine($"Between {first} and {last}:");
        Console.WriteLine($"Even numbers: {even}");
        Console.WriteLine($"Odd numbers: {odd}");
        
    }

    (int evenCount, int oddCount) CountEvenAndOdd(int start, int end)
    {
        int evenCount = 0;
        int oddCount = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                evenCount++;
            }

            else
            {
                oddCount++;
            }
        }
        return (evenCount, oddCount);
    }
}
