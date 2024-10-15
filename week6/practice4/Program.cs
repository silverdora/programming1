namespace practice4;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //enter radius
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        Circle circle1 = new Circle(radius);

        //display book information
        circle1.DisplayInfo();
    }
}

