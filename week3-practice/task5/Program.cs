namespace task5;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        while (true)
        {
            DisplayMenu();

            int choise = int.Parse(Console.ReadLine());

            if (choise == 5)
            {
                break;
            }

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            PerformCalculation(choise, firstNumber, secondNumber);

            Console.WriteLine("\n");
        }

        
    }

    int Add(int a, int b)
    {
        return (a + b);
    }

    int Subtract(int a, int b)
    {
        return (a - b);
    }

    int Multiply(int a, int b)
    {
        return (a * b);
    }

    double Divide(int a, int b)
    {
        return (double)a / b;
    }

    void DisplayMenu()
    {
        Console.WriteLine($"Simple Calculator Menu:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        Console.Write("Enter your choice: ");
    }

    void PerformCalculation(int choise, int first, int second)
    {
        switch (choise)
        {
            case 1:
                Console.WriteLine($"The result is {Add(first, second)}");
                break;

            case 2:
                Console.WriteLine($"The result is {Subtract(first, second)}");
                break;

            case 3:
                Console.WriteLine($"The result is {Multiply(first, second)}");
                break;

            case 4:
                if (second == 0)
                {
                    Console.WriteLine("Error: division by 0");
                    break;
                }
                Console.WriteLine($"The result is {Divide(first, second)}");
                break;
        }
    }
}
