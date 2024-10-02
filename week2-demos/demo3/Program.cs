namespace demo3;

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
        CheckNumber(enteredNumber);
    }

    void CheckNumber(int number)
    {
        if (number == 0)
        {
            Console.WriteLine("The number is zero");
        }
        else if (number > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is negative");
        }
    }
}