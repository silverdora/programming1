namespace practice6;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        int[] diceCounts = { 0, 0, 0, 0, 0, 0 };
        ThrowDice(diceCounts, 6000);
    }

    void ThrowDice(int[] diceCounts, int numberOfThrows)
    {
        Random random = new Random();

        for (int i = 0; i < 6000; i++)
        {
            int value = random.Next(1, 7);
            diceCounts[value-1]++;
        }

        for (int j = 1; j <= 6; j++)
        {
            Console.WriteLine($"Number of throws of value {j} = {diceCounts[j-1]}");
        }

    }
}

