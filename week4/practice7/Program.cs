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
        bool[] seats = new bool[10];
        InitializeSeats(seats);
        DisplaySeatingArrangement(seats);

        Console.Write("\nEnter the seat number to book (1-10): ");
        int seatNumber = int.Parse(Console.ReadLine());

        
            
        
        
        
        BookSeat(seats, seatNumber);
    }

    void InitializeSeats(bool[] seats)
    {
        Random random = new Random();
        for (int i = 0; i < seats.Length; i++)
        {
            int check = random.Next(0, 2);
            if (check == 0)
            {
                seats[i] = false;
            }
            else
            {
                seats[i] = true;
            }
        }
    }

    void DisplaySeatingArrangement(bool[] seats)
    {
        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i])
            {
                Console.WriteLine($"Seat {i + 1}: Available");
            }
            else
            {
                Console.WriteLine($"Seat {i + 1}: Booked");
            }
        }
         
    }

    void BookSeat(bool[] seats, int seatNumber)
    {
        while (!seats[seatNumber - 1])
        {
            Console.Write($"Seat {seatNumber} is already booked. Choose another seat: ");
            seatNumber = int.Parse(Console.ReadLine());
        }

        seats[seatNumber - 1] = false;

        Console.WriteLine($"Seat {seatNumber} has been successfully booked.\n");
        Console.WriteLine("Current seating arrangement:");

        DisplaySeatingArrangement(seats);
    }
}

