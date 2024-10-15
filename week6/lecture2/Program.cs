namespace lecture2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int number1 = 0;
        FillValue1(number1);
        Console.WriteLine($"{number1}");

        FillValue2(ref number1);
        Console.WriteLine($"{number1}");

        int[] numbers = new int[20];
        FillNumbers(numbers);
        Console.WriteLine($"{numbers[0]}");
    }

    void FillNumbers(int[] numbers) // array (an instance) > pass by reference
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }
    }

    void FillValue1(int number) //string > pass by value
    {
        number = 10;
    }

    void FillValue2(ref int number) //string > pass by value
    {
        number = 10;
    }
}

