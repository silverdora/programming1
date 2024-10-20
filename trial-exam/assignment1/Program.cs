using System;

namespace assignment1;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        //get the distance
        Console.Write("Enter the running distance (in kilometers): ");
        double distance = double.Parse(Console.ReadLine());

        // get the time;
        Console.Write("Enter the time taken (in minutes): ");
        int time = int.Parse(Console.ReadLine());

        //choose calculation
        Console.Write("\nDo you want to calculate pace (min/km) or speed (km/hr)? ");
        string calculation = Console.ReadLine();

        // display result
        switch (calculation)
        {
            case "pace":
                double pace = GetPace(distance, time);
                Console.WriteLine($"Your pace is {pace:0.00} min/km");
                break;

            case "speed":
                double speed = GetSpeed(distance, time);
                Console.WriteLine($"Your speed is {speed:0.00} km/hr");
                break;

            default:
                Console.WriteLine($"Incorrect input");
                break;
        }
    }

    double GetPace(double distance, int time)
    {
        double pace = time / distance;
        return pace;
    }

    double GetSpeed(double distance, int time)
    {
        double timeInHours = time / 60.0;
        double speed = distance / timeInHours;
        return speed;
    }
}