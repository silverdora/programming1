using System;

namespace assignment3;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // make an array
        int[] array = new int[20];
        FillNumbers(array);

        //display average
        int average = GetAverage(array);
        Console.WriteLine($"calculated average number: {average}");

        //display array
        DisplayNumbers(array, average);
    }

    void FillNumbers(int[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }
    }

    int GetAverage(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum/ numbers.Length;
    }

    void DisplayNumbers(int[] numbers, int average)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < average)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (numbers[i] > average)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{numbers[i]} ");
        }
    }
}
