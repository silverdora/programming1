namespace task3;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter and integer: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"Multiplication table of {input}:");
        PrintMultiplicationTable(input);
    }

    void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {number} = {i * number}");
        }
    }
}

