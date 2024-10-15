namespace lecture1;

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
    }
}
