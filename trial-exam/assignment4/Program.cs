namespace assignment4;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Drink[] drinks = new Drink[4];
        drinks[0] = new Drink("Coca-Cola", 3.00, false);
        drinks[1] = new Drink("Orange juice", 3.00, false);
        drinks[2] = new Drink("Beer", 3.50, true);
        drinks[3] = new Drink("Wine", 4.50, true);

        DisplayDrinks(drinks);
        double sum = 0;
        while (true)
        {
            Console.Write("\nSelect a drink to order: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
                break;
            else
            {
                Console.Write($"How many {drinks[choice - 1].Name} do you want to order? ");
                int amount = int.Parse(Console.ReadLine());
                sum += drinks[choice - 1].Price * amount;
            }
        }
        Console.WriteLine($"\nTotal proce you have to pay: {sum:0.00}");
    }

    void DisplayDrinks(Drink[] drinks)
    {
        for (int i = 0; i < drinks.Length; i++)
        {
            Console.WriteLine($"{i+1}. {drinks[i].GetDescription()}");
        }
    }
}


