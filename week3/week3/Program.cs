namespace week3;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int value = int.Parse(Console.ReadLine());
        while (value != 0)
        {
            Console.WriteLine($"Do sth with value {value}");
            value = int.Parse
                (Console.ReadLine());
        }
        Console.WriteLine("end");


    }
}

