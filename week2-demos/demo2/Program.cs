namespace demo2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {

        Console.WriteLine("PLease enter a number: ");
        int enteredNumber = int.Parse(Console.ReadLine());
        if (IsEven(enteredNumber))
        {
            Console.WriteLine($"{enteredNumber} is an even number");
        }
        else
        {
            Console.WriteLine($"{enteredNumber} is an odd number");
        }
    }

    bool IsEven(int number)
    {
        return (number % 2 == 0);
    }
}
