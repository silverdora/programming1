namespace assignment5;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Machine machine1 = ReadMachine();
        machine1.DisplayInfo();
    }

    Machine ReadMachine()
    {
        Console.Write("Enter machine name: ");
        string name = Console.ReadLine();

        Console.Write("Enter number of working hours: ");
        int hours = int.Parse(Console.ReadLine());

        Machine machine = new Machine(name, hours);
        return machine;
    }
}

