namespace demo5;

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

        Console.WriteLine("Enter the third number ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"The largest number is {FindMax(firstNumber, secondNumber, thirdNumber)}");
    }

    int FindMax(int first, int second, int third)
    {
        if (first >= second)
        {
            if (first >= third)
            {
                return first;
            }
            else
            {
                return third;
            }
        }
        else
        {
            if (second >= third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }

}

