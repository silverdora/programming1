namespace task7;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter Dimension size: ");

        int size = int.Parse(Console.ReadLine());

        PrintSquare(size);
    }

    void PrintSquare(int dimensionSize)
    {
        for (int column = 1; column <= dimensionSize; column++)
        {
            for (int row = 1; row <= dimensionSize; row++)
            {
                if ((column == 1 || column == dimensionSize))
                {
                    Console.Write("X");
                }
                else
                {
                    if (row == 1 || row == dimensionSize)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.Write("\n");
        }
    }
}

