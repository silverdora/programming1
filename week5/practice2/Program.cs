namespace practice2;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //enter a day
        Console.Write("Enter a day of the week (e.g., Monday): ");
        string input = Console.ReadLine();

        //convert to an enum value
        Day day = (Day)Enum.Parse(typeof(Day), input);

        //print a message
        switch (day)
        {
            case Day.Monday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Tuesday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Wednesday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Thursday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Friday:
                Console.WriteLine("Weekend is loading…");
                break;

            case Day.Saturday:
                Console.WriteLine("It's weekend!! Party time!");
                break;

            case Day.Sunday:
                Console.WriteLine("It's weekend!! Party time!");
                break;
        }
    }
}