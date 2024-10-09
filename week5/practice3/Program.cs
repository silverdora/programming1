namespace practice3;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    { 
        //create an array of integers
        Console.WriteLine("Enter 3 integers:");
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //calculate and display the sum 
        int sum = Calculator.CalculateSum(numbers);
        Console.WriteLine($"Sum: {sum}");

        //calculate and display the average
        double average = Calculator.CalculateAverage(numbers);
        Console.WriteLine($"Average: {average:0.00}");
    }
}
