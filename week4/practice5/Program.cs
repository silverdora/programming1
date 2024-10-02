using System.Diagnostics.Metrics;

namespace practice5;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] numbers = new int[20];

        ReadNumbers(numbers);

        Console.Write("Enter a search value: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine($"Number of occurrences of search value ({value}) " +
            $"is: {CountSearchValue(numbers, value)}");
        
    }

    void ReadNumbers(int[] numbers)
    {
        int number;
        int amountOfEnteredNumbers = 0;
        do
        {
            Console.Write("Enter a number(0 = stop): ");
            number = int.Parse(Console.ReadLine());
            numbers[amountOfEnteredNumbers] = number;
            amountOfEnteredNumbers += 1;
        }
        while ((number != 0) || (amountOfEnteredNumbers == numbers.Length));
    }

    int CountSearchValue(int[] numbers, int searchValue)
    {
        int numberOfOccurrences = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (searchValue == numbers[i])
            {
                numberOfOccurrences += 1;
            }
        }

        return numberOfOccurrences;
    }


}

