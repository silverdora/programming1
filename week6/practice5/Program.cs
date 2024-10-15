namespace practice5;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // get original value
        Console.Write("Original value: ");
        int number = int.Parse(Console.ReadLine());

        // display modifications
        ModifyByValue(number);
        Console.WriteLine($"Value after ModifyByValue: {number}");

        ModifyByReference(ref number);
        Console.WriteLine($"Value after ModifyByReference: {number}");
    }

    void ModifyByValue(int value)
    {
        value = value * 2;
    }

    void ModifyByReference(ref int value)
    {
        value = value * 2;
    }
}
