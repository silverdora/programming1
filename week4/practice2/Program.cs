namespace practice2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }


    void Start()
    {
        const int numberOfElements = 20;
        int[] randomNumbers = new int[numberOfElements];
        FillArray(randomNumbers);
        DisplayArray(randomNumbers);
        Console.WriteLine($"\nSmallest number is: {GetSmallestNumber(randomNumbers)}");

    }

    void FillArray(int[] numbers)
    {
        const int lowestPossibleValue = 1;
        const int highestPossibleValue = 100;

        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(lowestPossibleValue, highestPossibleValue + 1);
        }
    }

    void DisplayArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }
    }

    int GetSmallestNumber(int[] numbers)
    {
        int smallestNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallestNumber)
            {
                smallestNumber = numbers[i];
            }
        }
        return smallestNumber;
    }
}


