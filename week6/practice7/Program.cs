namespace practice7;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //enter name and price
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter product price: ");
        double productPrice = double.Parse(Console.ReadLine());

        Product product1 = new Product(productName, productPrice);

        //display book information
        product1.DisplayProductInfo();
    }
}
