namespace practice3;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //enter characteristics
        Console.Write("Enter car make: ");
        string make = Console.ReadLine();

        Console.Write("Enter car model: ");
        string model = Console.ReadLine();

        Console.Write("Enter car year: ");
        int year = int.Parse(Console.ReadLine());

        Car car1 = new Car(make, model, year);

        //display book information
        car1.DisplayCarInfo();
    }
}

