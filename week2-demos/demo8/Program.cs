namespace demo8;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        Console.Write("Enter a number (1-7) to get the day of the week: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The day is: {GetDayOfWeek(number)}");
    }

    string GetDayOfWeek(int dayNumber)
    {
        if (dayNumber < 1 || dayNumber > 7)
        {
            return "Invalid day number";
        }
        else
        {
            string dayName = "";
            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                case 7:
                    dayName = "Sunday";
                    break;
            }
            return dayName;
        }
    }
}

