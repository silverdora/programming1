namespace lecture0;
internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Player player1 = new Player("Piet", 100, 2100);
        Player player2 = new Player("Laura", 200, 400);

        player1.AddScore(-100);

        Console.WriteLine(player1);
        Console.WriteLine($"{player1.GetScore()}");

        player1.Name = "Peter";
        player1.Level = 1;
        Console.WriteLine($"{player1.TotalScore}");
        player1.Level = -2;
        Console.WriteLine($"{player1.TotalScore}");
    }
}

