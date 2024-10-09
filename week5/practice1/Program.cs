namespace practice1;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //enter width and height
        Console.Write("Enter width: ");
        double width = int.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = int.Parse(Console.ReadLine());

        //calculate
        Rectangle rectangle = new Rectangle();
        double area = rectangle.CalculateArea(width, height);
        double perimeter = rectangle.CalculatePerimeter(width, height);

        //display
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");

    }
}

