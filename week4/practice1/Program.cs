namespace practice1;

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
        for (int i = 1; i <= numbers.Length; i++)
        {
            Console.WriteLine($"Element {i} is: {numbers[i-1]}");
        }
    }
}
