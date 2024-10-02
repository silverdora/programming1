namespace demo4;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.WriteLine("Enter the first number ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /) ");
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine($"The result is {AddNumbers(firstNumber, secondNumber)}");
                break;

            case '-':
                Console.WriteLine($"The result is {SubtractNumbers(firstNumber, secondNumber)}");
                break;

            case '*':
                Console.WriteLine($"The result is {MultiplyNumbers(firstNumber, secondNumber)}");
                break;

            case '/':
                Console.WriteLine($"The result is {DivideNumbers(firstNumber, secondNumber)}");
                break;
        }
    }

    int AddNumbers(int firstAddend, int secondAddend)
    {
        return (firstAddend + secondAddend);
    }

    int SubtractNumbers(int muniend, int subtrahend)
    {
        return (muniend - subtrahend);
    }

    int MultiplyNumbers(int multiplicand, int multiplier)
    {
        return (multiplicand * multiplier);
    }

    int DivideNumbers(int divisible, int divisor)
    {
        return (divisible / divisor);
    }
}
